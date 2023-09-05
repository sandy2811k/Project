using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Jagged_Array
{
    internal class book_Array
    {
        static void Main(string[] args)
        {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            book_Array[] list = new book_Array[3]
            {
            new book_Array{Id=1,Name=" ",Price=100},
            new book_Array {Id=2,Name="  ",Price = 56000},
            new book_Array{Id=3,Name="  ",Price=54000 }
            };
            foreach (Employe2 book in list)
            {
                Console.WriteLine($" {book.Id} {book.Name} {book.Sal}");
            }
            Console.ReadLine();
        }
}
