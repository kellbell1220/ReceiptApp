using System;
using static System.Console;


namespace ReceiptApp
{
    class Receipt
    {
        //Declaring Variables
        public String receiptNumber;
        private String customerNumber;
        public String firstName;
        public String lastName;
        public String phoneNumber;
        public String address;
        public String itemNumber;
        public String itemDescription;
        private double itemPrice;
        public int itemQuantity;
        public String receiptDate;

        //Default Constructor

        public Receipt()
        {

        }

        public Receipt(String firstName, String lastName, double itemPrice)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.itemPrice = itemPrice;
        }

        public Receipt(String receiptNumber, String receiptDate, String itemDescription, String itemNumber, int itemQuantity, double itemPrice)
        {
            this.receiptNumber = receiptNumber;
            this.receiptDate = receiptDate;
            this.itemDescription = itemDescription;
            this.itemNumber = itemNumber;
            this.itemQuantity = itemQuantity;
            this.itemPrice = itemPrice;
        }

        public Receipt(String itemDescription, String itemNumber, int itemQuantity, double itemPrice)
        {
            this.itemDescription = itemDescription;
            this.itemNumber = itemNumber;
            this.itemQuantity = itemQuantity;
            this.itemPrice = itemPrice;
        }

        //Private Field for Customer Number Getter and Setter
        public String CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                customerNumber = value;
            }

        }

        //Private Field for ItemPrice Getter and Setter
        public double ItemPrice
        {
            get
            {
                return itemPrice;
            }
            set
            {
                itemPrice = value;
            }

        }



        public String ReturnFullName()
        {
            String name = firstName + " " + lastName;
            return name;
        }

        public double ReturnGrandTotal()
        {
            return ItemPrice * itemQuantity;
        }


        public override string ToString()
        {
            return "Customer: " + ReturnFullName() + "\nPhone Number: " + phoneNumber + "\nAddress:"+ address + "\nItem Purchased: " + itemNumber 
                +" Item Description: " + itemDescription + "\nTotal Purchases: " + ReturnGrandTotal().ToString("C");
        }
    }
}
