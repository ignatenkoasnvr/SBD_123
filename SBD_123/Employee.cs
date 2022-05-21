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

    public override void Work()
    {
      WriteLine ("Работаю: ");
    }
  }
}

