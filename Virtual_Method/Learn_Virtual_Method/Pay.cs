using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Method.Learn_Virtual_Method
{
    class Pay
    {
        public virtual void Calculate_Pay(int basicPay,int houseRent)
        {
            Console.WriteLine("Ordinary Pay Is : {0}",basicPay+houseRent);
        }
    }
}
