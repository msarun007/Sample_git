using Stripe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace PurchaseApp.ViewModel
{
    public class CreditCardViewModel :INotifyPropertyChanged
    {
        public CreditCardViewModel()
        {

        }

        public string CreateToken(string cardNumber, string cardExpMonth, string cardExpYear, string cardCVC)
        {
            StripeConfiguration.SetApiKey("pk_test_xxxxxxxxxxxxxxxxx");

            var tokenOptions = new StripeTokenCreateOptions()
            {
                Card = new StripeCreditCardOptions()
                {
                    Number = cardNumber,
                    ExpirationYear = cardExpYear,
                    ExpirationMonth = cardExpMonth,
                    Cvc = cardCVC
                }
            };

            var tokenService = new StripeTokenService();
            StripeToken stripeToken = tokenService.Create(tokenOptions);

            return stripeToken.Id; // This is the token
        }



        private string _creditCardNumber;
        public string CreditCardNumber
        {
            get { return _creditCardNumber; }
            set { _creditCardNumber = value; OnPropertyChanged(); }
        }

        private string _ExpiryDate;
        public string ExpiryDate
        {
            get { return _ExpiryDate; }
            set { _ExpiryDate = value; OnPropertyChanged(); }
        }

        private string _CVV;
        public string CVV
        {
            get { return _CVV; }
            set { _CVV = value; OnPropertyChanged(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
