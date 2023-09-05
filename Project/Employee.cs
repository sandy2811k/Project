using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project
{
    public class Employee : IPrintable1
    {
        protected int Id;                                //members of emp class its (variables)
        protected string Name;
        protected double Salary, hra, da, ta, pf, gross;
        protected static int count;
        // constructor
        /* public Employee() //parameter less constructor
         { //assign default value
             Id = 0;
             Name = "";
             Salary = 0.0;
         }*/

        public Employee(string name, double salary) //parameter constructor
        {
            count++;
            this.Id = count;
            this.Name = name;
            this.Salary = salary;

        }
        public static int GetEmpCount()
        {
            return count;
        }

        public virtual void CalculateSalary()
        {
            hra = Salary * 0.40;
            da = Salary * 0.20;
            ta = Salary * 0.10;
            pf = Salary * 0.12;
            gross = (Salary + hra + da + ta) - pf;

        }
        public string ShowEmployee()
        {
            return $"Employee Data: Id={Id} ,Name={Name} ,Salary={Salary} ,Gross={gross}";
        }
        public string Print()
        {
            return "Using Print in Employee";

        }

    }/*
        //Manager is child class ,Employee is base/parent class 
        public class Manager : Employee
        {
            private double foodallownce;

            public Manager(double foodallownce, string name, double salary) : base(name, salary)
            {
                this.foodallownce = foodallownce;
            }
            public override void CalculateSalary()
            {
                hra = Salary * 0.40;
                da = Salary * 0.20;
                ta = Salary * 0.10;
                pf = Salary * 0.12;
                gross = (Salary + hra + da + ta+foodallownce) - pf;

            }
            public string ShowManager()
            {
                return $"Manager Data: Id={Id} ,Name={Name} ,Salary={Salary} ,Gross={gross}";
            }
        }
    // SalesEmployee class
    public class SalesEmployee : Employee
    {
        
        private float bonus;
        private float comm;

        public SalesEmployee(float bonus, float comm,string name,double salary ) : base(name, salary)
        {
            this.bonus = bonus;
            this.comm = comm;
        }
        public override void CalculateSalary()
        {

            hra = Salary * 0.40;
            da = Salary * 0.20;
            ta = Salary * 0.10;
            pf = Salary * 0.12;
            gross = (Salary + hra + da + ta+bonus+comm) - pf;
        }
        public string ShowSalesEmp()
        {
            return $"Sales Employee Data: Id={Id} ,Name={Name} ,Salary={Salary} ,Gross={gross}";

        }
    }

    
*/
}
