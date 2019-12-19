using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopicoEspeciais.Extensions;

namespace TopicoEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2019, 12, 19, 17, 10, 45);
            Console.WriteLine(dt.ElapsedTime());


            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));

            

            Console.ReadKey();
        }
    }
}
