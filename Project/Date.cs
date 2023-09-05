using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Date
    {
        private int day, year;
        private string month;



       public void Accept_Project(int dd, string mm, int yy)
         {  day=dd;
            month=mm;
            year=yy;

         }
       
         public string Print_Date()
       {
        return $"Date:- {day} /{month} /{year}" ;
       }
    }
}
