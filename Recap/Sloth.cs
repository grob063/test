using System;
using System.Collections.Generic;
using System.Text;

namespace Recap
{
    public abstract class Sloth : Animal
    {
        public override string SaySomething()
        {
            return "Something";
        }

        public List<string> ListOfStrings { get; set; }
    }
}
