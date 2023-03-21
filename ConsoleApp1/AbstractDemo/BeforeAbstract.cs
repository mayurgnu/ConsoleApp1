using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AbstractDemo
{
    public class Before_FullTimeEmployee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AnnualSalary { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
    public class Before_ContractEmployee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HourlyPay { get; set; }
        public int TotalHours { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public int GetMonthlySalary()
        {
            return this.TotalHours * this.HourlyPay;
        }
    }
}
