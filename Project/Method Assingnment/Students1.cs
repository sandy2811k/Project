using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Method_Assingnment
{
    public class Students1
    {
        //add method displayData inside Student class change
        //values of id name in that method & also print the changed
        //values in same method.Call displayData method from
        //main method and see the output.Observe displayData can
        //only be called by creating object of Student

        private int id;
        private string name;

        public Students1(int id, string name)
        { 
            this.id= id;    
            this.name= name;
        
        }

        public string DisplayMethod()
        {
            this.id = 123;                       // comment (this.id & this.name) then we enter new data 
            this.name = "sandesh kshirsagar";    
            return $"{id},{name}";
        }
        
    }
}
