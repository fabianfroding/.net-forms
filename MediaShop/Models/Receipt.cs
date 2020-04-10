using System;
using System.Collections.Generic;

namespace MediaShop.Models
{
    class Receipt
    {
        public string date;
        public List<int> productIds;

        public Receipt()
        {
            // Här skapas kvittots skapelse-datum, vilket används som kvittots identifiering.
            // fff läggs till för att undvika att kvitton skapas med samma identifiering,
            // d.v.s. alla kvitton är unika.
            date = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            productIds = new List<int>();
        }
    }
}
