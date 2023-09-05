using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Person      //Parent class

    {
        protected string name;            //members
        protected string address;
        protected long aadharnumber;
        
        public Person(string name,string address,long adharnumber) //PArameterised constructor
        {
          this.name = name;
            this.address = address; 
            this.aadharnumber = adharnumber;
        }
        public string DisplayPerson()
        { 
            return $"Name:{name},Address:{address},Adhar Number:{aadharnumber}";
        }
    }

    //child class

    public class Patient : Person
    {
        protected string bloodg; //variable fist letter are always in small char
        protected double bill;
        private string gender;
        
        public Patient(string bloodg,double bill,string name,string gender,string address,long adharnumber):base(name,address,adharnumber) //constrocter  //(Person)parent cls():(Patient)base cls()
        {
            this.bloodg = bloodg; //
            this.bill = bill; 
            this.gender = gender;
        }
        public string DisplayPatient() //calling method
        {
            return $"{name},{address},Blood Group: {bloodg},Gender:{gender},Bill: {bill}";
        }

    }
    
}
