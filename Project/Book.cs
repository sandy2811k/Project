using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Book
    {
        private int Book_id, price;
        private string   Book_name ,auther_name;
        //constructor
        public Book() // parameter less constructor
        {// assign default value
            Book_id = 0;
            price = 0;
            Book_name = " ";
            auther_name = "";
            
        }
        public Book(int id, int pri, string name,string autname)//parameter constructor
        {
            this.Book_id=id;
            this.price = pri;
            this.Book_name = name;
            this.auther_name = autname;

        }
        public string ShowBook()
        {
            return $"Book info.:- Id={Book_id} ,Price={price} ,Book Name={Book_name} ,Auther Name={auther_name}";
        }
    }
}
