using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class CAr
    {
        private string companyName, modelName;
        private int cost;
                                              //Default Parameter
        public CAr(string modelName,int cost,string companyName="Tata") 
        {
            this.companyName = companyName;
            this.modelName = modelName; 
            this.cost = cost;       
        }
        public void Accept(string modelName,string companyName="Tata")
        {

        }
        public string Print()
        {
            return $"{companyName},{modelName},{cost}";
        }

    }
}
