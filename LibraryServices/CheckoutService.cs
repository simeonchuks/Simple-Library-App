using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryServices
{
    public class CheckoutService : ICheckout
    {
        private LibraryContext _context;

        public CheckoutService(LibraryContext context)
        {
            _context = context;
        }
        public void Add(Checkout newCheckout)
        {

            _context.Add(newCheckout);
            _context.SaveChanges();
        }

        public IEnumerable<Checkout> GetAll()
        {
            return _context.Checkouts;
        }

        public Checkout GetById(int checkoutId)
        {
            return GetAll().FirstOrDefault(checkout => checkout.Id == checkoutId);
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int id)
        {
            //we will include LibraryAsset and LibraryCard
            return _context.CheckoutHistories
                   .Include(h => h.LibraryAsset)
                   .Include(h => h.LibraryCard)
                   .Where(h => h.LibraryAsset.Id == id);
        }

        public IEnumerable<Hold> GetCurrentHolds(int id)
        {
            return _context.Holds.Include(h => h.LibraryAsset)
                   .Where(h => h.LibraryAsset.Id == id);
        }

        public Checkout GetLatestCheckout(int assetId)
        {
            return _context.Checkouts.Where(c => c.LibraryAsset.Id == assetId)
                   .OrderByDescending(c => c.Since)
                   .FirstOrDefault();
        }

        public void MarkFound(int assetId)
        {
            var now = DateTime.Now;

            UpdateAssetStatus(assetId, "Available");
            RemoveExistingCheckouts(assetId);
            CloseExistingCheckoutHistory(assetId, now);

            _context.SaveChanges();
        }

        public void MarkLost(int assetId)
        {
            //GET the data from the db and store it in item
            //var item = _context.LibraryAssets
            //    .FirstOrDefault(a => a.Id == assetId);
            ////Update the item(Track it for an update operation)
            //_context.Update(item);
            ////add the item status to the status table 
            //item.Status = _context.Statuses
            //    .FirstOrDefault(status => status.Name == "Lost");
            UpdateAssetStatus(assetId, "Lost");
            _context.SaveChanges();
        }

        public void CheckInItem(int assetId)
        {
            var now = DateTime.Now;

            var item = _context.LibraryAssets
                .FirstOrDefault(a => a.Id == assetId);

            //_context.Update(item);

            // Remove any existing checkout item
            RemoveExistingCheckouts(assetId);

            //Close any existing checkout history
            CloseExistingCheckoutHistory(assetId, now);

            //look for existing holds on the item 
            var currentHolds = _context.Holds
                .Include(h => h.LibraryAsset)
                .Include(h => h.LibraryCard)
                .Where(h => h.LibraryAsset.Id == assetId);

            //if there are existing holds, checkout the item to the librarycard with
            //the earliest hold

            if (currentHolds.Any())
            {
                CheckoutToEarliestHold(assetId, currentHolds);

                return;
            }

            // Otherwise update the item status to available

            UpdateAssetStatus(assetId, "Available");

            _context.SaveChanges();
        }

        public void CheckOutItem(int assetId, int libraryCardId)
        {
            if (IsCheckedout(assetId))
            {
                return;
                //This is where you add handle your feedback logic
            }

            var item = _context.LibraryAssets
            .FirstOrDefault(a => a.Id == assetId);

            //Update our status.. instead of writing code repeated codes judt call our update method
            UpdateAssetStatus(assetId, "Checked Out");

            var libraryCard = _context.LibraryCards
                .Include(card => card.Checkouts)
                .FirstOrDefault(card => card.Id == libraryCardId);

            //Create a new checkout
            var now = DateTime.Now;

            var checkout = new Checkout
            {
                LibraryAsset = item,
                LibraryCard = libraryCard,
                Since = now,
                Until = GetDefaultCheckoutTime(now)
            };

            _context.Add(checkout);

            var checkoutHistory = new CheckoutHistory
            {
                CheckedOut = now,
                LibraryAsset = item,
                LibraryCard = libraryCard
            };

            _context.Add(checkoutHistory);

            _context.SaveChanges();
        }

        public bool IsCheckedout(int assetId)
        {
            var isCheckedout = _context.Checkouts
               .Where(co => co.LibraryAsset.Id == assetId)
               .Any();

            return isCheckedout;
        }

        public void PlaceHold(int assetId, int libraryCardId)
        {
            var now = DateTime.Now;

            var asset = _context.LibraryAssets
                .Include(a => a.Status)
                .FirstOrDefault(a => a.Id == assetId);

            var card = _context.LibraryCards
                .FirstOrDefault(c => c.Id == libraryCardId);

            //when you place a hold, You need to check if the item is available
            if (asset.Status.Name == "Available")
            {
                UpdateAssetStatus(assetId, "On Hold");
            }

            var hold = new Hold
            {
                HoldPlaced = now,
                LibraryAsset = asset,
                LibraryCard = card
            };

            _context.Add(hold);
            _context.SaveChanges();
        }


        public string GetCurrentHoldPatronName(int holdId)
        {
            var hold = _context.Holds
                .Include(h => h.LibraryAsset)
                .Include(h => h.LibraryCard)
                .FirstOrDefault(h => h.Id == holdId);

            //Get the current Id from that hold
            var cardId = hold?.LibraryCard.Id;

            //Get the patron from the cardId
            var patron = _context.Patrons.Include(p => p.LibraryCard)
                .FirstOrDefault(p => p.LibraryCard.Id == cardId);

            return patron?.FirstName + " " + patron?.LastName;
        }

        public DateTime GetCurrentHoldPlaced(int holdId)
        {
            return _context.Holds
                 .Include(h => h.LibraryAsset)
                 .Include(h => h.LibraryCard)
                 .FirstOrDefault(h => h.Id == holdId)
                 .HoldPlaced;
        }

        public string GetCurrentCheckoutPatron(int assetId)
        {
            var checkout = GetCheckoutByAssetId(assetId);

            if (checkout == null)
            {
                return "";
            };

            var cardId = checkout.LibraryCard.Id;

            var patron = _context.Patrons
                .Include(p => p.LibraryCard)
                .FirstOrDefault(p => p.LibraryCard.Id == cardId);

            return patron.FirstName + " " + patron.LastName;
        }

       


        //Creating methods to refactor our application============================================
        private void CloseExistingCheckoutHistory(int assetId, DateTime now)
        {
            //close any existing checkout history
            var history = _context.CheckoutHistories
                .FirstOrDefault(h => h.LibraryAsset.Id == assetId
                    && h.CheckedIn == null);

            if (history != null)
            {
                _context.Update(history);
                history.CheckedIn = now; //Let create the now varaible at the top
            }
        }

        private void RemoveExistingCheckouts(int assetId)
        {
            //If the item is found, remove any existing checkout
            var checkout = _context.Checkouts.FirstOrDefault(co => co.LibraryAsset.Id == assetId);

            if (checkout != null)
            {
                _context.Remove(checkout);
            }
        }

        private void UpdateAssetStatus(int assetId, string newStatus)
        {
            var item = _context.LibraryAssets
                 .FirstOrDefault(a => a.Id == assetId);

            _context.Update(item);

            item.Status = _context.Statuses
                .FirstOrDefault(status => status.Name == newStatus);
        }

        private void CheckoutToEarliestHold(int assetId, IQueryable<Hold> currentHolds)
        {
            var earliestHold = currentHolds
                .OrderBy(holds => holds.HoldPlaced)
                .FirstOrDefault();

            var card = earliestHold.LibraryCard;

            _context.Remove(earliestHold);
            _context.SaveChanges();
            CheckOutItem(assetId, card.Id);
        }

        private DateTime GetDefaultCheckoutTime(DateTime now)
        {
            return now.AddDays(30);
        }

        private Checkout GetCheckoutByAssetId(int assetId)
        {
            return _context.Checkouts
                   .Include(co => co.LibraryAsset)
                   .Include(co => co.LibraryCard)
                   .FirstOrDefault(co => co.LibraryAsset.Id == assetId);
        }

        //private bool IsCheckedOut(int assetId)
        //{
        //    return _context.Checkouts
        //        .Where(co => co.LibraryAsset.Id == assetId)
        //        .Any();
        //}
    }    
      
}
