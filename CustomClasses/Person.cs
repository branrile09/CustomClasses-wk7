using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClasses
{

    //this is a cool trick ive learnt, we can give summary to var&functs
    //  

    ///intellisense
    /// <summary>
    /// our base class e.g Person, 
    /// all types of people will inherit from this
    /// </summary>
    internal class Person
    {
        //all variables should be private or protected,
        //with rare instances where public is acceptible. 
        // we are keeping public variables for demonstation purposes
        public int age;
        public float height;
        
        public string name;
        public string eyeColour;
        public bool hair;
        public string hairColour;

        /*pro tip:
        use  ctrl+m + o to close all brackets,
        use  ctrl+m + x to open all brackets,
        helps with navigating through large classes and frameworks
        
        also you can click on reference on objects and functions to see where used. 
        */



        //----------------------------Constructors
        public Person() 
        { 
            this.age = 0;
            //height is in centimeters, because feet is stupid
            //metric is the real freedom units!!!!
            this.height = 0;
            name = string.Empty;
            eyeColour = string.Empty;
            hairColour = string.Empty;
            hair = false;        
        }

        public Person(int age, float height, string name, string eyeColour, bool hair, string hairColour)
        {
            this.age = age;
            this.height = height;
            this.name = name;
            this.eyeColour = eyeColour;
            this.hairColour = hairColour;
            this.hair = hair;
        }
        //overloading, creates new object from 2 old objects
        public Person(Person Father, Person Mother)
        {
            this.age = 0; //newborn
            this.height = 15;
            name = string.Empty; //ideally we would have input a name from args/params
            eyeColour = Father.eyeColour;
            hairColour = Mother.hairColour;
            hair = false;
        }




        //------------------interactive functions
        // this is how we should interact with objects,
        // should refrain from accessing variables directly



        /// <summary>
        /// this increases age by 1
        /// </summary>
        public void HappyBirthday()
        {
            age++;
            Console.WriteLine($"Happy Birthday {name} you are now {age} yrs young");
        }

        /// <summary>
        ///  person now grows 5cm
        /// </summary>
        /// more info
        /// https://stackoverflow.com/questions/529677/how-to-have-comments-in-intellisense-for-function-in-visual-studio
        public void growHeight()
        {
            this.height += this.height + 5;
        }

        public void growHeight(int i)
        {
            this.height += this.height + i;
        }
        


    }
}
