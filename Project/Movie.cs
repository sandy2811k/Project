using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Movie
    {
        private int mid;
        private string mname;
        private int tprice;
        private string type;
        private int nooftickets = 20;
        private int num, totalcost, avalible;


    
    public Movie(int mid, string mname)
    {
        this.mid = mid;
        this.mname = mname;
       
        
         

    }
    public string DisplayMovie()
    {
            return $"Id:{mid},Name:{mname},Price:{tprice},Total Cost:{totalcost} ,No of tickets:{nooftickets},Remening Tickets:{avalible}";
        
       
    }
        public void AvailableTickets()
        {
            Console.Write("Enter Number of tickets to book:-");
            num = int.Parse(Console.ReadLine());
            if (nooftickets > num)
            { avalible = nooftickets - num;
                this.CalculateTicketCost();
            } else
            { Console.WriteLine("Insufficient Tickets"); }
   
        
        
        }
        public void CalculateTicketCost()
        {
            Console.WriteLine(" 1.Silver-100rs\n 2.Gold=200rs\n 3.Platinum=300rs ");
            Console.Write("Enter Type:-");
            int choice=int.Parse(Console.ReadLine());

        switch (choice)
          {         case 1:
                    type = "Silver";
                    tprice = 100;
                    break;

                    case 2:
                    type = "Gold";
                    tprice = 200;
                    break;

                    case 3:
                    type = "Platinum";
                    tprice = 300;
                    break;
          }
            totalcost = num*tprice;

        }
        public string DisplayAmt()
        {
            return $"Id:- {mid},Movie_Name:- {mname},Price:- {type}-{tprice}Rs,Total_Cost:- {totalcost}Rs,Remening_Tickets:- {avalible}";


        }
    }
    
}