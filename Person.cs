using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassesPractice
{
    public class Person
    {
        // Create a constructor
        public Person() { }

        // Properties
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        // methods
        public void DisplayName( )
        {     
            Console.WriteLine(" My Name is: {0} {1}", FirstName, LastName);
        }
        public void DisplayEmail()
        {
            Console.WriteLine("Email is: {0}", Email);
        }
 
    }

}
