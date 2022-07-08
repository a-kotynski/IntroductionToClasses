using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2205232#content
namespace IntroductionToClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Class is a building block of an application
            // each class is responsible for a particular behaviour of an application

            // Anatomy of a Class

            * Data (represented by fields)
            * Behaviour (represented by methods)

            
            * public is an access modifier
            PascalCase
            camelCase

            */
            // Creating Objects
            Person person = new Person();
            var person2 = new Person();

            // Using Objects
            person.Name = "Abe";
            person.Introduce();

            /*
            // Class Members
            * Instance: accessible from an object
            var person = new Person();
            person.Introduce();

            * Static: accessible from the class
            Console.WriteLine(); 
             */

        }
    }
    //Declaring Classes

    public class Person
    {
        public string Name;
        public static int PeopleCount = 0;
        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name);
        }
    }
}