using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//FIND THE CODE SMELL and REFACTOR 
    public enum PaymentType
    {
        CreditCard,Paypal,GoogleCheckout,AmazonPayments
    }
   	public class OnlineCart
    {
        public void CheckOut(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.CreditCard:
                    ProcessCreditCardPayment();
                    break;
                case PaymentType.Paypal:
                    ProcessPaypalPayment();
                    break;
                case PaymentType.GoogleCheckout:
                    ProcessGooglePayment();
                    break;
                case PaymentType.AmazonPayments:
                    ProcessAmazonPayment();
                    break;
            }
        }

        private void ProcessCreditCardPayment()
        {
            //Credit Card Processing Logic
        }

        private void ProcessPaypalPayment()
        {
            //Paypal payment Processing Logic
        }

        private void ProcessGooglePayment()
        {
            //Google payment Processing Logic
        }

        private void ProcessAmazonPayment()
        {
            //Amazon payment Processing Logic
        }
    }


