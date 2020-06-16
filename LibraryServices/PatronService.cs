using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LibraryServices
{
    public class PatronService : IPatron
    {
        private LibraryContext _context;

        public PatronService(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Patron newPatron)
        {
            _context.Add(newPatron);
            _context.SaveChanges();
        }

        public IEnumerable<Patron> GetAll()
        {
            return _context.Patrons
             .Include(patron => patron.LibraryCard)
             .Include(patron => patron.HomeLibraryBranch);

        }

        public Patron GetById(int id)
        {
            //You can get it like this or
            //return _context.Patrons
            //    .Include(patron => patron.LibraryCard)
            //    .Include(patron => patron.HomeLibraryBranch)
            //    .FirstOrDefault(patron => patron.Id == id);

            //Refactor it Like this
            return GetAll()
                   .FirstOrDefault(patron => patron.Id == id);
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int patronId)
        {
            //Checkout history is associated with card id so we will check for their card id first
            var cardId = _context.Patrons
                  .Include(patron => patron.LibraryCard)
                  .FirstOrDefault(patron => patron.Id == patronId)
                  .LibraryCard.Id;

            return _context.CheckoutHistories
                .Include(co => co.LibraryCard)
                .Include(co => co.LibraryAsset)
                .Where(co => co.LibraryCard.Id == cardId)
                .OrderByDescending(co => co.CheckedOut);
        }
       

        public IEnumerable<Checkout> GetCheckouts(int patronId)
        {
            //Get the card Id
            var cardId = _context.Patrons
                 .Include(patron => patron.LibraryCard)
                 .FirstOrDefault(patron => patron.Id == patronId)
                 .LibraryCard.Id;

            return _context.Checkouts
                .Include(co => co.LibraryCard)
                .Include(co => co.LibraryAsset)
                .Where(co => co.LibraryCard.Id == patronId);
        }

        public IEnumerable<Hold> GetHolds(int patronId)
        {
            var cardId = GetById(patronId).LibraryCard.Id;

            return _context.Holds
                .Include(hold => hold.LibraryCard)
                .Include(hold => hold.LibraryAsset)
                .Where(hold => hold.LibraryCard.Id == cardId)
                .OrderByDescending(h => h.HoldPlaced);
        }
    }
}
