using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace oop_laboratory1
{
    /// <summary>
    /// Class Student to demostrate encapsulation 
    /// Student class include properties such as student ID, first name, last name, and grade.
    /// </summary>
    class StudentEncapsulationDemo
    {
        //Declaring properties of the class using PascalCase convetion for each name's properties
        //These attributes are private (by default the members are private)  
        int StudentId;
        string FirstName;

        //These attributes are declared private in explicity way using the keyword 'private'
        private string LastName;
        private double Grade;

        //Defining a getter method for student id
        public int GetStudentId()
        {
            return StudentId;
        }

        //Defining a getter method for first name 
        public string GetFirstName()
        {
            return FirstName;
        }


        //Defining a getter method for last name 
        public string GetLastName()
        {
            return LastName;
        }

        //Defining a getter method for grade
        public double GetGrade()
        {
            return Grade;
        }

        //Defining a setter method for student id
        public void SetStudentId(int studentId) 
        {
            this.StudentId = studentId;
        }

        //Defining a setter method for first name
        public void SetFirstName(string firstName) 
        {
            this.FirstName = firstName;
        }

        //Defining a setter method for last name
        public void SetLastName(string lastName) 
        {
            this.LastName = lastName;
        }

        //Defining a setter method for grade
        public void SetGrade(double grade) 
        {
            //Validation to ensure that grade is within the range of 0 to 100
            if (grade >= 0 && grade <= 100)
            {
                //Update grade property with a validated value 
                this.Grade = grade;
            }
            else 
            {
                //Throwing an error message for the user 
                throw new ArgumentException("Grade must be between 0 and 100");
            }
        }
    }
}
