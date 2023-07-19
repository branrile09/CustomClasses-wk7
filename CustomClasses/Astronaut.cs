using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClasses
{
    //matts custom class
    internal class Astronaut : Person
    {
        bool SpaceSuit;
        string Status;

        Astronaut() {
            this.SpaceSuit = true;
            this.Status = "alive";
        }

        Astronaut(bool spaceSuit)
        {
            this.SpaceSuit = spaceSuit;
            if (this.SpaceSuit)
            {
                this.Status = "Alive";
            }
            else
            {
                this.Status = "UnAlive";
            }
        }
        
        string GetStatus()
        {
            return this.Status;
        }


    }
}
