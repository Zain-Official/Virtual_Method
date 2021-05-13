using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Method.Learn_Virtual_Method
{
    class Grade1 :Pay
    {
        public override void Calculate_Pay(int basicPay, int houseRent)
        {
            Console.WriteLine("Grade 1 Pay Is : {0}",basicPay+houseRent);
        }
        
    }
}
