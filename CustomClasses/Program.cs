
namespace CustomClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pro tip:
            // right click on variables, then rename,
            // will rename that variable within the entire scope of use
            // also ctrl+shift+s will save changes to all project files. 



            //we can create a person under default constructor
            Person person = new Person(); 

            //we can create using an overload constructor with args
            Person RB = new Person(20, 177, "Riley", "blue", true, "Brown");
            
            //we can modify public attributes/variables of these objects
            RB.name = "Richard Branson";
            RB.hair = false;

            //we are now creating students, a student is a new class that inherits all
            //public and protected variables and functions
            //if a var/funct is private, it cannot be inherited, 
            // protected acts like private but can be inherited
            Student MGLR = new Student(age: 20, height: 183,
                                     name: "Matt", hair: true,
                                     eyeColour: "green", hairColour: "brown");

            Student BC = new Student(20, 180, "Blake", "blue", false, "none");

            //we can create a person thats subclass is a student, 
            //but we cant make a student from a person, this is due to polymorphism
            Person JM = new Student(20, 184, "Joelene", "blue", true, "brown");

            //new person inherits some attributes from mother and father
            Person newBaby = new Person(BC, JM);            


            //we are accessing public functions, 
            JM.HappyBirthday();
            MGLR.growHeight();
            //matthews birthday
            MGLR.HappyBirthday();
            // Matt is now a giant!!!
            do 
            {
                MGLR.growHeight();
            } while (MGLR.height < 350);
           


        }
    }
}