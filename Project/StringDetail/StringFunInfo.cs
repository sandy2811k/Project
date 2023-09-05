using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.StringDetail
{
    internal class StringFunInfo
    {
        static void Main(string[] args)
        {   
            string msg1 = "Hellow To All";
            string msg2 = "Good Morning";

            //Method To string class 
            string str1=string.Concat(msg1," ", msg2.TrimEnd());
            Console.WriteLine(str1);

        }
    }
}
