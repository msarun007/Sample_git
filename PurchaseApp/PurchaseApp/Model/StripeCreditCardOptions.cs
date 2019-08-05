using System;
using System.Collections.Generic;
using System.Text;

namespace PurchaseApp.Model
{
    public class StripeCreditCardOptions
    {
        public class Card
        {
            public string Number { get; set; }
            public string ExpirationYear { get; set; }
            public string ExpirationMonth { get; set; }
            public string Cvc { get; set; }
        }
       
    }
}
