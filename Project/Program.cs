using Project.Method_Assingnment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
   



    //  static void Main(string[] args)
    // { //[------------------------Employee----------------------]
    /* [1st type]
    //parameter less constructor get called
    //Employee employee = new Employee(); //Employee() call to constructor
    //parametric constructer get called
    Employee employee2 = new Employee("sandesh k",55000);
    Employee employee3 = new Employee( "rohit j", 50000);
    Employee employee4 = new Employee("raj k", 60000);

    employee2.CalculateSalary();
    employee3.CalculateSalary();
    employee4.CalculateSalary();
    Console.WriteLine(employee2.ShowEmployee());
    Console.WriteLine(employee3.ShowEmployee());
    Console.WriteLine(employee4.ShowEmployee());

    Console.WriteLine("Total Emp Count:"+Employee.GetEmpCount());
    */
    //[For manager]
    /*
    Manager manager = new Manager(5500, "Sandesh k", 55000);
    manager.CalculateSalary();
    Console.WriteLine(manager.ShowManager());
    */
    //[for Sales Employee]
    /*
    SalesEmployee salesEmployee = new SalesEmployee(500, 600, "rushi k", 85000);
    salesEmployee.CalculateSalary();
    Console.WriteLine(salesEmployee.ShowSalesEmp());
    */
    //[IPrintable]
    /*
    Employee employee = new Employee("rohit",12345);
    employee.CalculateSalary();
    Console.WriteLine(employee.ShowEmployee());
    Console.WriteLine(employee.Print()); 
    */
    //[--------------Student--------------------------------]

    /*            
    Student student = new Student();
    Student student2 = new Student(1, 88, 55, 97, "sandesh k", "mech");
    Student student3 = new Student(2, 75, 84, 91, "rushi k", "civil");
    student2.Calculate();
    Console.WriteLine(student2.ShowStudent());
    student3.Calculate();
    Console.WriteLine(student3.ShowStudent());
    */

    //[-------------------Book------------------------------]
    /*
     Book bookObj1 = new Book();
     bookObj1.AcceptBookDetails(123, 500, "ravan", "Sharad tandale");
     string res4=bookObj1.ShowBook();
     Console.WriteLine(res4);
     */


    //[----------------product---------------------]
    /*
    //Property initializer  syntax

    Product product = new Product();
    product.Code = 1;
    product.Name ="i watch";
    product.Price = 50000;

    // It calls get accessor
    Console.WriteLine($"{product.code},{product.name},{product.price}");
    Console.WriteLine(product.Print());

    //Object initiazlier syntax
    Product product2 = new Product() {code=1,name="mobile",price=85245 };
    Console.WriteLine($"{product2.code},{product2.name},{product2.price}");
    Console.WriteLine(product2.Print());
    Console.ReadLine();
    */

    //[-------------------Movie-----------------------------]

    /*
    Movie movie=new Movie(1,"(3 idiots)");
    movie.DisplayMovie();
    movie.AvailableTickets(); 
    Console.WriteLine(movie.DisplayAmt());
    movie.DisplayAmt();

    Console.ReadLine();
    */
    /*
                //[------------------------moviee----------------------]
                moviee m1 = new moviee("3idiots", 111);//create object and enter info
                Console.WriteLine(m1.print());         //3idiots,111,50
                Console.WriteLine(m1.CalcuTicket());   //40-cal method
                Console.WriteLine(m1.print());         //3idiots,111,40

                moviee m2 = new moviee("pk", 222);
                Console.WriteLine(m2.print());
                Console.WriteLine(m2.CalcuTicket());
                Console.WriteLine(m2.print());
                Console.WriteLine(m2.CalcuTicket());    
    */

    //[--------------Account---------------------------------]
    /*
    Account ac = new Account();
    Account ac1= new Account(123,"Saving",15000);

    Console.WriteLine(ac1.show());
    Console.WriteLine("Enter amount to Deposite");
    int amt=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(ac1.DepositeMoney(amt));
    Console.WriteLine("Enter Amount to Withdraw");
    int amt1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(ac1.WithdrawMoney(amt1));
    Console.WriteLine(ac1.show());
    */

    //[-------------Calculation------------------------------]
    /*
   Calculation calculation = new Calculation();
   Console.WriteLine(calculation.Addition(1,2));
   Console.WriteLine(calculation.Addition(5.5,9.1));

   Console.ReadLine();
  */

    //[---------------------CAr-----------------------------]
    /*
    CAr car = new CAr("Harrier", 150000);
    CAr car2 = new CAr("Thar", 2000000, "Mahindra");
    CAr car3 = new CAr("Nexon", 1500000);

    Console.WriteLine(car.Print());
    Console.WriteLine(car2.Print());
    Console.WriteLine(car3.Print());
    Console.ReadLine();
    */

    //[[--------------------Students1--------------------------]
    /*
    Students1 studs1 = new Students1(234,"Rohit Jadhav"); //comment in main then get new data  
    Console.WriteLine(studs1.DisplayMethod());            //otherwise main data display
    */

    //[-----------------StudGetId---------------------------]
    /*
    StudGetId Sgid= new StudGetId(12,"raj"); //name replace by main name in class
    Console.WriteLine(Sgid.Display());
    */

    //[------------------Patient----------------------------]
    /*
    Patient patient = new Patient("B+", 15000, "Rohit j", "pune", 123456789);
    Console.WriteLine(patient.DisplayPerson());
    Console.WriteLine(patient.DisplayPatient());
    */
    //[------------------Shape-------------------------------]
    /*
    Rectangle rectangle = new Rectangle(5, 6);
    Console.WriteLine(rectangle.Display());
    rectangle.Display();
    rectangle.Area();
    Console.WriteLine(rectangle.area);
    Console.WriteLine(rectangle.Draw("Rectangle"));
    */

    /*
    Rectangle rectangle = new Rectangle(5,6);
    Console.WriteLine(rectangle.Display());
    rectangle.Area();
    rectangle.Print();
    rectangle.Display();
    Console.WriteLine(rectangle.area);
    Console.WriteLine(rectangle.Draw("Rectangle"));
    */
    //[----------------IPrintable----------------------------]//
    /*
    User user = new User();
    Console.WriteLine(user.Print());
    */
    //[----------------IPrintable1---------------------------]




}