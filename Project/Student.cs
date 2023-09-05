using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Project
{
    public class Student
    {
        
        private int roll_n;
        private float Sub1, Sub2, Sub3;
        private float per, tot;
        private string name, branch;
        private static int count;
        // constructor
        public Student()
        {
            //assign default vale
           
            Sub1 = 0;
            Sub2 = 0;
            Sub3 = 0;
            per = 0;
            tot = 0;
            name = " ";
            branch = " ";
        }
        public Student(float sub1, float sub2, float sub3, string name, string branch)
        {
            count++;
            this.roll_n = count;
            this.Sub1 = sub1;
            this.Sub2 = sub2;
            this.Sub3 = sub3;
            this.name = name;
            this.branch = branch;
        }
        public static int GetStudentCount()
            { return count;
             }

        public void Calculate()

        {
            

              tot = Sub1 + Sub2 + Sub3 ;
              per = ( tot / 300) * 100;    //,1st Subject={Sub1} ,2ns subject={Sub2} ,3rd subject={Sub3}
            if (per > 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (per > 60)
            {
                Console.WriteLine("Grade B");
            }
            else
            {
                Console.WriteLine("Grade c");
            }
        }
        public string ShowStudent()
        {
            return $"Student details:- Name={name} ,Roll No.={count} ,Branch={branch} ,Persentage={per} ,Total={tot} ";
        }
    }
}
