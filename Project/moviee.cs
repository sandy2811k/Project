using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class moviee
    {
        private  string mName;
        private int mId;
        private static int NoofSeats=50;

        public moviee(string mName, int mId)
        {
            this.mName = mName;
            this.mId = mId;
        }

        public int CalcuTicket()
        {
            NoofSeats = NoofSeats - 10;
            return NoofSeats;
        }
        public  string print()
        {
            return $"Movie Name:{mName},Id:{mId},tickets:{NoofSeats}";
        }


    }
}
