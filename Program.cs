using System;
using static System.Console;

namespace ReceiptApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\tReceipt Application");
            //Create an Employee Object
            Receipt receipt1 = new Receipt();
            receipt1.receiptNumber = AskForInput("Receipt Number");
            receipt1.CustomerNumber = AskForInput("Customer's Number");
            receipt1.firstName = AskForInput("Customer's First Name");
            receipt1.lastName = AskForInput("Customer's Last Name");
            receipt1.phoneNumber = AskForInput("Customer's Phone Number");
            receipt1.address = AskForInput("Customer's Address");
            receipt1.itemNumber = AskForInput("Item Purchased");
            receipt1.itemDescription = AskForInput("Item Description");
            receipt1.ItemPrice = AskItemPrice();
            receipt1.itemQuantity = AskForInt("Quantity");

            Receipt receipt2 = new Receipt("XYC-2345", "09/25/2013", "Wiper blade", "4XZ23-7", 2, 9.50);
            Receipt receipt3 = new Receipt("Anna", "Leigh", 21.66);
            Receipt receipt4 = new Receipt("Brake Fluid", "XQ-1267", 5, 14.78);

            
            //Printing out First Test
            WriteLine("\n\tFirst Test");
            WriteLine(receipt1.ToString());


            //Printing out Second Test
            WriteLine("\n\n\tSecond Test");
            WriteLine("Receipt Number: " + receipt2.receiptNumber + " - Date: " + receipt2.receiptDate);
            WriteLine("Description of Part: " + receipt2.itemDescription);
            WriteLine("Item Number: " + receipt2.itemNumber);
            WriteLine("Quantity Purchased: " + receipt2.itemQuantity);
            WriteLine("Total Cost: " + receipt2.ReturnGrandTotal().ToString("C"));

            //Printing out Third Test
            WriteLine("\n\n\tThird Test");
            WriteLine(receipt3.ToString());

            //Printing out last test
            WriteLine("\n\n\tLast Test");
            WriteLine("Description of Part: " + receipt4.itemDescription);
            WriteLine("Item Number: " + receipt4.itemNumber);
            WriteLine("Quantity Purchased: " + receipt4.itemQuantity);
            WriteLine("Unit Price: " + receipt4.ItemPrice);
            WriteLine("Total Cost: " + receipt4.ReturnGrandTotal().ToString("C"));

           ReadKey();
        }

        //Aquiring Customer and Item Information
        static String AskForInput(String whichOne)
        {
            Write("Enter {0}: ", whichOne);
            String inValue = ReadLine();

            return inValue;
        }

        //Aquiring Item Price
        static double AskItemPrice()
        {
            Write("Enter Unit Price: ");
            String inValue = ReadLine();

            return double.Parse(inValue);
        }

        //Aquiring Item Quantity
        static int AskForInt(String whichOne)
        {
            Write("Enter {0}: ",whichOne);
            String inValue = ReadLine();

            return int.Parse(inValue);
        }

    }

}
   