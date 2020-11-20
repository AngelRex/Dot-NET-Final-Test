//In the space provided on this page write a program using these instructions:
//1.Create two classes, one called ‘Adult’ and one called ‘Child’ with the following string properties:
//a.First Name
//b.    Last Name
//2.    Populate the first and last name properties in both the Adult and Child classes.
//3.    Create a single array to hold both the Adult and Child classes.
//4.    Populate the array with one Adult class and one Child class. 
//5.Use the array in a loop and print the Adult and Child first and last name properties to the console.



using System;

namespace NET_Intro_Final_Test
{
    class Program
    {
        static void Main()
        {
            PersonProp[] pp = new PersonProp[2];
            pp[0] = new Adult("C#", ".NET");
            pp[1] = new Child("Ruby", "Rails");
            foreach (PersonProp p in pp)
                Program.printNames(p);

        }

        public static void printNames(PersonProp pp)
        {
            Console.WriteLine($"\n\tFirstName: {pp.fname}\t LastName: {pp.lname}");
        }
        public class PersonProp
        {
            public string fname, lname;
            public PersonProp(string x, string y)
            {
                fname = x;
                lname = y;
            }
        }
        public class Adult : PersonProp
        {
            public Adult(string x, string y) : base(x, y)
            {
            }
        }

        public class Child : PersonProp
        {

            public Child(string x, string y) : base(x, y)
            {
            }
        }
 
    }
}
