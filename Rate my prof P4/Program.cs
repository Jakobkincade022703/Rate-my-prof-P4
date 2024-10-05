/* Name: Jakob Kincade
 * Section: CS258-00x
 * Date: 09/27/2024
 * Program description: 
 */
using System;
using System.Xml.Linq;

namespace P4
{
    public class Professor
    {
        // Private member variables (e.g., the first and last name)

        private string firstName;

        private string lastName;

        private string affiliation;

        private int easiness = 5 ;

        private int helpfulness = 5  ;

        // The first Professor constructor

        public Professor(string firstName, string lastName, string affiliation)
        {

            this.firstName = firstName;
            this.lastName = lastName;
            this.affiliation = affiliation;

        }

        // The second Professor constructor
        // Textbook@P204

        public Professor(string firstName, string lastName, string affiliation, int easiness, int helpfulness)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.affiliation = affiliation;
            this.easiness = easiness;
            this.helpfulness = helpfulness;
        }

        // Define affiliation as a property
        // Textbook@P210
        
        public string Affiliation
        {
            get
            {
                return affiliation;
            }

            set
            {
                affiliation = value;
            }
        }


        // Accessor and mutator for the easiness grade
        // Textbook@P208

        public int GetEasiness(int easiness)
        {
            return easiness;
        }

        public void SetStudentAge(int easiness)
        { this.easiness = easiness; }


        // Accessor and mutator for the helpfulness grade
        // Textbook@P208
        public int GetHelpfulness(int helpfulness)
        {
            return helpfulness;

        }

        public void SetHelpfulness(int helpfulness)
        {
            this.helpfulness = helpfulness;
        }
        // Override the ToString() method
        // Textbook@P213, Example 4-11

        public override string ToString()
        {
            string name = firstName + " " + lastName +" "+ Affiliation+" "+ helpfulness+" "+easiness;
            return name;

        }
            

        // A display method that prints out the first name, the last name,
        // affiliation, and the two grades
        public void Display()
        {
            Console.WriteLine(ToString());
            
        }

    }


    class Program
    {

        // Main method to demonstrate how the Professor class works
        static void Main(string[] args)
        {
            // Create an instance of the Professor class
            // Textbook@P215

            Professor p4;
            p4 = new Professor("Xue", "Han", "USI");
            p4.Display();
           
            // Invoke the display method of the above Professor instance
            // Textbook@P218
        }
    }
}
