using System;

namespace sbscFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int CustomerId ;
            string Customername;
            double UnitConsumed;
            double price;
            double BillAmount;
            double TotalBillAmount =0;
            double surcharge =0;

            Console.WriteLine("You go like use this software calculte you water bill?, oya first give me some info about you");
            Console.WriteLine("Wetin be your Id");
            CustomerId = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Okay, tell me your name");
            Customername = Console.ReadLine();

            Console.WriteLine("Welcome" + " " + Customername + ", " + "enter amount of water you don use:");
            UnitConsumed = Convert.ToDouble(Console.ReadLine());

        
            if (UnitConsumed <= 199)
            {
                price = 1.20;
            }
            else if(UnitConsumed >= 200 && UnitConsumed < 400)
            {
                price = 1.50;
            }
            else if(UnitConsumed >= 400 && UnitConsumed < 600)
            {
                price = 1.80;
            }
            else
                 price = 2.0;
            
            BillAmount = UnitConsumed * price;

            if(BillAmount > 300)
            {
                surcharge = BillAmount * 15/100;
                TotalBillAmount = BillAmount + surcharge;
            }
            if (BillAmount < 100)
            {
                TotalBillAmount = BillAmount;
            }
            
            Console.WriteLine("\nAbeg see your Water Bill under");
            Console.WriteLine("************************************************");
            Console.WriteLine("Customer Id                       :" + CustomerId);
            Console.WriteLine("Unit Consumed                      :" + UnitConsumed);
            Console.WriteLine("Amount Charges for " + "" + UnitConsumed + " unit" + " for" + " "+ "N"+price +  " na     :"  + BillAmount );
            Console.WriteLine("Surchage Amount                   :" + surcharge);
            Console.WriteLine("Total Amount Paid you'd pay    :" + "" + TotalBillAmount );
            Console.WriteLine("*************************************************");
        }
    }
}
