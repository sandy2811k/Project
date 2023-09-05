using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Product
    {  // Create Product class with code, name & Price. Assign value using property
       // Use both property & object initializer syntax, & display the product details

        public int code;
        public string name;
        public double price;

       
        public int Code
        {
            set { code = value; }
            get { return code; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        public string Print()
        {
            return $"Product Detail:{code},{name},{price}";
        }
    }
    
}
