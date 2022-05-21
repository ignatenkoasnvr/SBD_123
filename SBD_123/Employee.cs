using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SBD_123
{
  public  class Employee:Human
    {
        //1
        //public double Salary { get; set; }
        //public  Employee( string _FirstName, string _LastName, int _Age, double _Salary)
        //{
        //   FirstName = _FirstName;
        //   LastName = _LastName;
        //   Age = _Age;
        //   Salary=_Salary;
        //}
        //2
        public double salary;
        public Employee(string _firstname, string _lastname, int _age, double _salary) :
            base(_firstname, _lastname, _age)
        {
            salary = _salary;
        }
        public virtual void Print()
        {
            base.Print();
            WriteLine($"  {salary} ");
        }
        public override string ToString()
        {
            return base.ToString() + $"  {salary} ";
        }
    }
}

