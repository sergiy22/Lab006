using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab06Lib;

namespace Lab06App
{
    class Program
    {

        static void Main(string[] args)
        {
            Phone SamsungS7 = new Phone("Samsung", "Snapdragon", "Android", "S7");
            SamsungS7.Ram = 4;
            Console.WriteLine(SamsungS7);
            Phone IPhoneX = new Phone("IPhone", "A11", "ios", "X");
            IPhoneX.Ram = 3;
            Console.WriteLine(IPhoneX);
            Console.ReadKey();
        }

    }
}

