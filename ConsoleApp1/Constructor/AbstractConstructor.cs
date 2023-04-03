using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Demo of static constructor in nonstatic class
namespace ConsoleApp1.AbstractConstructor
{
    public static class AbstractConstructor_Main
    {
        public static void fnMain()
        {
            AbstractConstructor.fnStaticPrint("AbstractConstructor");
            AbstractConstructorChild1.fnStaticPrint("AbstractConstructorChild1");

            AbstractConstructorChild1 acc1 = new AbstractConstructorChild1();
            acc1.fnPrint("acc1");
            
            AbstractConstructorChild1 acc2 = new AbstractConstructorChild1();
            acc2.fnPrint("acc2");
            Console.ReadLine();
        }
    }
    //abstract class cannot be sealed or static
    public abstract class AbstractConstructor
    {
        private const int constvar = 10;
        private static readonly int readonlyvar = 10;
        static AbstractConstructor()
        {
            //constvar = 10;
            //The left-hand side of an assignment must be a variable, property or indexer.
            Console.WriteLine("Value of readonlyvar befor modification : {0}", readonlyvar);
            readonlyvar = 30;
            Console.WriteLine("static AbstractConstructor");
            Console.WriteLine("In Static AbstractConstructor readonly varible can be modified for once only");
            Console.WriteLine("For ex over here value of readonlyvar modified to : {0}", readonlyvar);
        }
        public AbstractConstructor()
        {
            Console.WriteLine("public AbstractConstructor");
        }
        public static void fnStaticPrint(string para)
        {
            Console.WriteLine("fnStaticPrint called by {0}", para);
        }
    }
    public class AbstractConstructorChild1 : AbstractConstructor
    {
        public AbstractConstructorChild1()
        {
            Console.WriteLine("AbstractConstructorChild1() called");
        }
        public void fnPrint(string para)
        {
            Console.WriteLine("AbstractConstructorChild1.fnPrint() {0}",para);
        }
    }
}
