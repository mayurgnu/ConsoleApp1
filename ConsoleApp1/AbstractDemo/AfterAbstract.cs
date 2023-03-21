using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AbstractDemo
{
    public abstract class Base_Employee
    {
        public int checkconstcalling { get; set; }
        public Base_Employee()
        {
            this.checkconstcalling = 100;
            Console.WriteLine("Base_Employee constructor called...");
            Console.WriteLine($"checkconstcalling is initialized to : {this.checkconstcalling}...");
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        public abstract int GetMonthlySalary();
    }
    public class After_FullTimeEmployee : Base_Employee
    {
        public int AnnualSalary { get; set; }
        public override int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
    public class After_ContractEmployee : Base_Employee
    {
        public int HourlyPay { get; set; }
        public int TotalHours { get; set; }

        public override int GetMonthlySalary()
        {
            return this.TotalHours * this.HourlyPay;
        }
    }
}
