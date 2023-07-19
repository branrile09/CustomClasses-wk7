using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClasses
{
    internal class Student : Person
    {

        public Student(int age, float height, string name, string eyeColour, bool hair, string hairColour)
        {
            this.age = age;
            this.height = height;
            this.name = name;
            this.eyeColour = eyeColour;
            this.hairColour = hairColour;
            this.hair = hair;
        }



    }
}
