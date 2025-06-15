using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal totalPaymentDelivery;
        private decimal totalPaymentWrap;
        private decimal totalPaymentGST;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }

        public decimal TotalPaymentDelivery
        {
            get { return totalPaymentDelivery; }
            set { totalPaymentDelivery = value; }
        }
        public decimal TotalPaymentWrap
        {
            get { return totalPaymentWrap; }
            set { totalPaymentWrap = value; }
        }
        public decimal TotalPaymentGST
        {
            get { return totalPaymentGST; }
            set { totalPaymentGST = value; }
        }
        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
            Delivery = 25;
            Wrapping = 5;
            GST =  0.1M;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
            TotalPaymentDelivery = TotalPayment + Delivery;
            TotalPaymentWrap = TotalPaymentDelivery + Wrapping;
            TotalPaymentGST = TotalPaymentWrap + (TotalPayment * GST);
        }
    }
}
