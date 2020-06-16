using LibraryData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface ICheckout
    {
        void Add(Checkout newCheckout);

        IEnumerable<Checkout> GetAll();
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        IEnumerable<Hold> GetCurrentHolds(int holdId);

        Checkout GetById(int checkoutId);
        Checkout GetLatestCheckout(int assetId);

        DateTime GetCurrentHoldPlaced(int id);
        bool IsCheckedout(int assetId);

        string GetCurrentCheckoutPatron(int assetId);
        string GetCurrentHoldPatronName(int holdId);

        void PlaceHold(int assetId, int libraryCardId);
        void CheckInItem(int assetId);
        void CheckOutItem(int assetId, int libraryCardId);

        void MarkLost(int assetId);
        void MarkFound(int assetId);
       
        

        

    }
}
