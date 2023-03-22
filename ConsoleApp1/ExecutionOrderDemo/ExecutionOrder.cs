using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExecutionOrderDemo
{
    //Sequence of Excution Order in Parent Child Relationship
    //Child Initializers > Parent Initializers > Parent Constructor > Child Constructor 
    public static class ExecutionOrder
    {
        public static void fnMain()
        {
            Console.WriteLine("=====Parent p = new Parent()==========================");
            Parent p = new Parent();
            p.PrintRollNo();


            Console.WriteLine("=====Parent pc = new Child1()==========================");
            Parent pc = new Child1();
            pc.PrintRollNo();

            Console.WriteLine("=====Parent c1 = new Child1()==========================");
            Child1 c1 = new Child1();
            c1.PrintRollNo();
            c1.PrintStudentName();
            Console.ReadLine();
        }
    }
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine($"Parent()");
        }
        public int RollNo { get; set; }
        public void PrintRollNo()
        {
            Console.WriteLine($"Parent.PrintRollNo()");
        }
    }
    public class Child1 : Parent
    {
        public Child1()
        {
            Console.WriteLine($"Child1()");
        }
        public int StudentName { get; set; }
        public void PrintStudentName()
        {
            Console.WriteLine($"Parent.PrintStudentName()");
        }
    }
}
