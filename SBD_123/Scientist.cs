using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SBD_123

{
  class Scientist : Employee
  {
    string scientificDirection;
    public Scientist(string _firstname, string _lastname, int _age, double _salary, string direction) : base(_firstname, _lastname, _age, _salary)
    {
      scientificDirection = direction;
    }
    public override void Print()
    {
      base.Print();
      WriteLine($" {scientificDirection}");
    }
    public void ShowScientist()
    {
      WriteLine($"Ученый. Научное направление: {scientificDirection}");
    }
    public override string ToString()
    {
      return base.ToString() + $"  {scientificDirection} ";
    }
    public override void Work()
    {
      base.Work();
      WriteLine(" Придумываю вечный двигатель.");
    }
  }
}
