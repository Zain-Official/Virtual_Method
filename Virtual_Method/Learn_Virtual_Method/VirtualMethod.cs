using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Method.Learn_Virtual_Method
{
    class VirtualMethod
    {
        static void Main(string[] args)
        {
            Pay p = new Pay();
            p.Calculate_Pay(5000, 3000);
            Console.WriteLine("\n************************\n");
            Pay p2 = new Grade1();
            p2.Calculate_Pay(15000, 9000);
            Console.ReadKey();

        }
    }
}
