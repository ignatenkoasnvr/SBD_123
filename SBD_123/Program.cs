using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SBD_123
{
  class Program
  {
    static void Main(string[] args)
    {
      //Manager m1 = new Manager("Ella_meneg", "Chornogor_meneg", 20, 1000, "IT");
      //WriteLine(m1);
      Employee m1 = new Manager("Ella_meneg", "Chornogor_meneg", 20, 1000, "IT");
      Employee[] employees =
      {
                m1,
                new Scientist ("Ella_scientist", "Chornogor_meneg", 20, 1000, "IT"),
                new Specialist("Ella_specialist", "Chornogor_meneg", 20, 1000, "IT")
            };
      //Scientist sc = new Scientist("Ella_scientist", "Chornogor_meneg", 20, 1000, "IT");
      //sc.Print();
      foreach (Employee item in employees)
      {
        item.Print();
        item.Work();

       // if (item is Manager) (item as Manager).ShowManager(); //3
       // if (item is Scientist) (item as Scientist).ShowScientist();
       // if (item is Specialist) (item as Specialist).ShowSpecialist();
        WriteLine("*************************************");
      }


      ReadKey();
    }

  }
}

// Scienist - string direction
// Specialist - string qualification
