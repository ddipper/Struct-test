using System;
using Test;

class Program
{
    static void Main()
    {
        Time t = new Time("0123 4567 8901 2345", "01/23", 012);
        Console.WriteLine(t.GetCard());
        Console.ReadKey();
    }
}

namespace Test
{
    struct Time
    {
        private string cardNumber, mmYY;
        private int cvc;

        public Time(string card, string mmYy, int cvv)
        {
            cardNumber = card; mmYY = mmYy; cvc = cvv; 
        }

        public string GetCard()
        {
            return cardNumber + "\n" + mmYY + "            " + cvc;
        }
    }
}