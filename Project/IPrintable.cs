using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public interface IPrintable
    {
        string Print();//By default public & abstract
    }

    public class User : IPrintable
    {
        public string Print()
        {
            return "user details";
        }
    }
}
