using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_laboratory1
{
    /// <summary>
    /// Class Student with some properties and implemt two constructors 
    /// (Default Constructor & Parameterized Constructor) to demostrate how these types of
    /// constructors works in OOP (how these initialize attributes)
    /// The name of the class always start with capital letter Example Student 
    /// </summary>
    class Student
    {
        //Declaring properties of the class using PascalCase convetion for each name's properties
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        //Implemeting an Explicit Default Constructor 
        public Student() { }

        //Implemeting an parameterized Constructor passing the values of each property
        //Tha variables parameter are declaring using camelcase convetion 
        public Student(int studentId, string firstName, string lastName, double grade) 
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        //Override method for ToString() to print a string representation of object
        //created from the instance of Student Class 
        public override string ToString()
        {
            //Using interpolation to print the value of each property of the object created 
            //from the Class Student 
            return $"Student Id: {StudentId}\nFirst Name: {FirstName}\nLast Name: {LastName}\nGrade: {Grade}";
        }

    }
}
