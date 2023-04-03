using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Demo of static constructor in nonstatic class
namespace ConsoleApp1.StaticConstructor
{
    public static class StaticConstructor_Main
    {
        public static void fnMain()
        {
            //StaticConstructor.fnPrint();
            Console.ReadLine();
        }
    }
    public static class StaticConstructor
    {
        private const int constvar = 10;
        private static readonly int readonlyvar = 10;
        static StaticConstructor()
        {
            //constvar = 10;
            //The left-hand side of an assignment must be a variable, property or indexer.
            Console.WriteLine("Value of readonlyvar befor modification : {0}", readonlyvar);
            readonlyvar = 30;
            Console.WriteLine("static StaticConstructor");
            Console.WriteLine("In Static StaticConstructor readonly varible can be modified for once only");
            Console.WriteLine("For ex over here value of readonlyvar modified to : {0}", readonlyvar);
        }
        public static void fnPrint()
        {
            Console.WriteLine("fnPrint called");
        }
    }
}
