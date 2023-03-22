using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism
{
    //ORV : Object Reference Variable
    //Note* : Method marked as override cannot be marked as new or virtual;
    //Polymorphism allows us to call derived class methods through base class reference during runtime.
    //Use New Keywrd
    //Parent class have method with name MethodMarkedWithNewKeyWord 
    //Child class have method with name MethodMarkedWithNewKeyWord but mark with new keyword
    //now if we try to access as following
    //Parent pc = new Child1();
    //pc.MethodMarkedWithNewKeyWord();
    //it will call MethodMarkedWithNewKeyWord of parent class and
    //output will be : Parent.MethodMarkedWithNewKeyWord()...

    //Conclusion
    //Prerequists : Two method with same name in parent and child class

    //if ORV is of type Parent and pointing to Child Object then below two cases are possible.
    
    //Case 1 : In child method marked as override
    //child version will be called.

    //Case 2 : In child method marked as new
    //Parent version will be called.

    public static class PolymorphismDemo
    {
        public static void fnMain()
        {
            //Main_AbstractDemo MAD = new Main_AbstractDemo();
            //MAD.fnMain();
            //ParellelForeach.fnParellelForeach();

            Console.WriteLine("=====Parent p = new Parent()==========================");
            Parent p = new Parent();
            p.OverRideDemo();
            p.MethodMarkedWithNewKeyWord();


            Console.WriteLine("=====Parent pc = new Child1()==========================");
            Parent pc = new Child1();
            pc.OverRideDemo();
            pc.MethodMarkedWithNewKeyWord();
            
            Console.WriteLine("========Child1 c1 = new Child1()=======================");
            Child1 c1 = new Child1();
            c1.OverRideDemo();
            c1.MethodMarkedWithNewKeyWord();

            Console.WriteLine("========Child1 c1c2 = new Child2()=======================");
            Child1 c1c2 = new Child2();
            c1c2.OverRideDemo();
            c1c2.MethodMarkedWithNewKeyWord();

            Console.WriteLine("========Child2 c2 = new Child2()=======================");
            Child2 c2 = new Child2();
            c2.OverRideDemo();
            c2.MethodMarkedWithNewKeyWord();
            Console.ReadLine();
        }
    }
    public class Parent
    {
        public int RollNO { get; set; }
        public virtual void OverRideDemo()
        {
            Console.WriteLine($"Parent.OverRideDemo()...");
        }
        public virtual void MethodMarkedWithNewKeyWord()
        {
            Console.WriteLine($"Parent.MethodMarkedWithNewKeyWord()...");
        }
    }
    public class Child1 : Parent
    {
        public string StudentName { get; set; }
        public override void OverRideDemo()
        {
            Console.WriteLine($"Child1.OverRideDemo()...");
        }
        public new void MethodMarkedWithNewKeyWord()
        {
            Console.WriteLine($"Child1.MethodMarkedWithNewKeyWord()...");
        }
    }
    public class Child2 : Child1
    {
        public override void OverRideDemo()
        {
            Console.WriteLine($"Child2.OverRideDemo()...");
        }
        public new void MethodMarkedWithNewKeyWord()
        {
            Console.WriteLine($"Child2.MethodMarkedWithNewKeyWord()...");
        }
    }
}
