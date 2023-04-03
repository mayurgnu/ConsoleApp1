using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Demo of static constructor in nonstatic class
namespace ConsoleApp1.Constructor
{
    public static class Constructor_Main
    {
         public static void fnMain()
        {
            Constructor c1 = new Constructor("c1");
            Constructor c2 = new Constructor("c2");
            Constructor c3 = new Constructor("c3");
            Constructor c4 = new Constructor("c4");
            Constructor c5 = new Constructor("c5");
            Console.ReadLine();
        }
    }
    public class Constructor
    {
        private const int constvar = 10;
        private static readonly int readonlyvar = 10;
        //1).A static constructor must be parameter less.
        //2).we cannot use access modifiers on the static constructor.
        //static Constructor(int a)
        //{
        //    Console.WriteLine("static Constructor");
        //}
        static Constructor()
        {
            //constvar = 10;
            //The left-hand side of an assignment must be a variable, property or indexer.
            Console.WriteLine("Value of readonlyvar befor modification : {0}", readonlyvar);
            readonlyvar = 30;
            Console.WriteLine("static Constructor");
            Console.WriteLine("In Static Constructor readonly varible can be modified for once only");
            Console.WriteLine("For ex over here value of readonlyvar modified to : {0}", readonlyvar);
        }        
        public Constructor(string ORV)
        {
            //readonlyvar = 10;
            //Fields of static readonly field 'name' cannot be assigned to
            //(except in a static constructor or a variable initializer)
            Console.WriteLine("public Constructor for {0}", ORV);
        }
    }
}
