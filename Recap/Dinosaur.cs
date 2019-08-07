using System;
using System.Collections.Generic;
using System.Text;

namespace Recap
{
    public class Dinosaur : Animal 
    {
        public int Age { get; set; }

        public Dinosaur(int age)
        {
            Age = age;
        }

        public string Roar (string roar)
        {
            return "roooooar" + roar;
        }

        public string Roar()
        {
            return Roar("something");
        }

        public override string SaySomething()
        {
            throw new NotImplementedException();
        }
    }
}
