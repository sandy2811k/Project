using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Method_Assingnment
{
    public class StudGetId
    {
           //Create getId() method in Student class. call getId() method
           //from displayData method so that you know that one
           //method can be called from another method.Return id
           //from getId() method and set that id to the instance
           //variable in displayData method
      
         private int id;
        private string name;
        

        public StudGetId(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Get_id()
        {   
            return id;
        }
        public string Display()
        { 
            this.Get_id();
            this.name="Sandesh";
            return $"Id={id},Name={name}";
        }



    }
}
