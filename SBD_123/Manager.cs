using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SBD_123
{
    class Manager:Employee
    {
        string activity;
       public Manager(string _firstname, string _lastname, int _age, double _salary, string _activity) :
            base(_firstname, _lastname, _age, _salary)
        {
            activity = _activity;
        }
        public override string ToString()
        {
            return base.ToString() + $"  {activity} ";
        }
      
        public override void Print()
    {
      base.Print();
      WriteLine($" {activity}");
    }

    public void ShowManager()
    {
      WriteLine($"Менеджер. Сфера деятельности: {activity}");
    }
    public override void Work()
    {
      base.Work();
      WriteLine(" Управляю бизнесом");
    }

  }
}
