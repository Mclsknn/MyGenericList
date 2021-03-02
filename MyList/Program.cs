using System;
using System.Collections.Generic;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList<int, string> dizi = new MyList<int, string>();
            dizi.Add(12, "Mustafa");
            dizi.Add(13, "Mustafa");
            dizi.Add(14, "Mustafa");
            dizi.Add(15, "Mustafa");

        }
    }
}
