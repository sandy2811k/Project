using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Jagged_Array
{
    public class Employe2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Sal { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Employe2[] list = new Employe2[3]
            {
            new Employe2{Id=1,Name="sandesh k",Sal=55000},
            new Employe2 {Id=2,Name="Rohit j",Sal = 56000},
            new Employe2{Id=3,Name="sujit s",Sal=54000 }
            };
            foreach (Employe2 employe in list)
            {
                Console.WriteLine($" {employe.Id} {employe.Name} {employe.Sal}");
            }
            Console.ReadLine();
        }
    }
}