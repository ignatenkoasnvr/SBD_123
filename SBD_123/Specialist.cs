using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SBD_123
{
  class Specialist : Employee
  {
    string qualification;
    public Specialist(string _firstname, string _lastname, int _age, double _salary, string _qualification) : base(_firstname, _lastname, _age, _salary)
    {
      _qualification = qualification;
    }
    public void ShowSpecialist()
    {
      WriteLine($"Специалист. Квалификация: { qualification}");
    }

    public override void Print()
    {
      base.Print();
      WriteLine($" {qualification}");
    }
    public override string ToString()
    {
      return base.ToString() + $"  {qualification} ";
    }
    public override void Work()
    {
      base.Work();
      WriteLine(" Кодю спагетти-код.");
    }
  }
}
