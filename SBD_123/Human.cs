using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SBD_123
{
    public abstract class Human
    {
        string firstname;
        string lastname;
        int age;
        public Human() { }
        public Human(string _firstName, string _lastName, int _age)
        {
            firstname = _firstName;
            lastname = _lastName;
            age = _age;
        }
      public abstract void Work();

        public virtual void Print()
        {
            WriteLine($" {firstname}  {lastname}  {age}");
        }
        public override string ToString()
        {
            return $" {firstname}  {lastname}  {age}";
        }
    }
}