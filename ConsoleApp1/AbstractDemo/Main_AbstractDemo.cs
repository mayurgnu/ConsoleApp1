using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AbstractDemo
{
    //copy paste below in program.cs
    //Main_AbstractDemo MAD = new Main_AbstractDemo();
    //MAD.fnMain();
    public class Main_AbstractDemo
    {
        public void fnMain()
        {
            fnBeforeAbstract();
            fnAfterAbstract();
            var aa = 10;
            fnGetVarDataTypValue(aa);
            Console.ReadLine();
        }

        public void fnGetVarDataTypValue(int aa)
        {
            Console.WriteLine($"fnGetVarDataTypValue called...{aa}");
        }
        public void fnBeforeAbstract()
        {
            Before_FullTimeEmployee fte = new Before_FullTimeEmployee()
            {
                ID = 101,
                FirstName = "Fulltime",
                LastName = "Employee",
                AnnualSalary = 100000
            };
            Before_ContractEmployee cte = new Before_ContractEmployee()
            {
                ID = 101,
                FirstName = "Contract",
                LastName = "Employee",
                TotalHours = 8,
                HourlyPay = 150
            };
            Console.WriteLine($"Before_FullTimeEmployee:{fte.GetFullName()}");
            Console.WriteLine($"Before_FullTimeEmployee:{fte.GetMonthlySalary()}");
            Console.WriteLine($"Before_ContractEmployee:{cte.GetFullName()}");
            Console.WriteLine($"Before_ContractEmployee:{cte.GetMonthlySalary()}");

        }

        public void fnAfterAbstract()
        {
            After_FullTimeEmployee fte = new After_FullTimeEmployee()
            {
                ID = 101,
                FirstName = "Fulltime",
                LastName = "Employee",
                AnnualSalary = 100000
            };
            After_ContractEmployee cte = new After_ContractEmployee()
            {
                ID = 101,
                FirstName = "Contract",
                LastName = "Employee",
                TotalHours = 8,
                HourlyPay = 150
            };
            Console.WriteLine($"After_FullTimeEmployee:{fte.GetFullName()}");
            Console.WriteLine($"After_FullTimeEmployee:{fte.GetMonthlySalary()}");
            Console.WriteLine($"After_ContractEmployee:{cte.GetFullName()}");
            Console.WriteLine($"After_ContractEmployee:{cte.GetMonthlySalary()}");

        }
    }
}
