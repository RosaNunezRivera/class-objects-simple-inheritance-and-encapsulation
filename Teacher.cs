using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_laboratory1
{
    /// <summary>
    /// Crating a child class from the parent class Student and adding a property type string
    /// called 'Subject'
    /// </summary>
    class Teacher : Student
    {
        //Declaring getter and setter of the property Subject
        public string Subject { get; set; }

        //Constructor of the derived class 'Student'
        public Teacher( int id, string firstName, string lastName, double grade, string subject)
       : base(id, firstName, lastName, grade) // Call parent class constructor 
        {
            Subject = subject;
        }

        //Creating a method in the child class to show a string 
        public string Teach() 
        {
            //Using interpolation functionaly print the value of SubJect in the child Class 
            //and print the value of LastName created from the parent class Student 

            return $"Mr./Ms. {LastName} is teaching {Subject}";
        }

    }
}
