using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateS
{
   
    public class Transition
    {
        public char Input { get; set; }
        public State TransiteTo { get; set; }

        public Transition(char input, State transiteTo)
        {
            Input = input;
            TransiteTo = transiteTo;
        }

        public override string ToString()
        {
           
            return $"--{Input}--> {TransiteTo.Name}";
        }
    }
}
