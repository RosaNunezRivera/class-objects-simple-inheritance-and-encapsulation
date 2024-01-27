using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace oop_laboratory1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                //Excercise 1. Class and Objects
                //Creating object with two constructors (Default Constructor & Parameterized Constructor)
                Student studentDefaultConstructor = new Student(); // Uses default constructor
                Student studentParameterizedConstructor = new Student(1, "Rosa", "Nunez", 4.5); // Uses parameterized constructor

                Console.WriteLine("Lab 1 Class and Objects, Simple Inheritance and Encapsulation\n");
                Console.WriteLine("Excercise No.1\n");
                Console.WriteLine("Result of Default Constructor");
                Console.WriteLine(studentDefaultConstructor.ToString());

                Console.WriteLine("\nResult with Parameterized Constructor");
                Console.WriteLine(studentParameterizedConstructor.ToString());

                //Excercise 2. Inharitance 
                //Create a derived class named `Teacher` that inherits from the `Student` class

                //Create an object of the child class 'Teacher' $ initialize its attributes
                Teacher teacher = new Teacher(1, "Parekh", "Harshil", 4.5, "Oriented Object Programing");


                Console.WriteLine("\nExcercise No. 2");
                //Demonstrating the use of the `Teach()` method.
                Console.WriteLine("Demostrating the use of the method Teach created in the child class Teacher");
                Console.WriteLine("Calling -->  teacher.Teach()  that means name of the class . method's name");
                Console.WriteLine(teacher.Teach());

                //Excercise 3. Encapsulation: 
                Console.WriteLine("\nExcercise No. 3");
                Console.WriteLine("Student Class with private attributes");
                StudentEncapsulationDemo encapsulationDemo = new StudentEncapsulationDemo();

                //Set property's values using setter method 
                encapsulationDemo.SetStudentId(100);
                encapsulationDemo.SetFirstName("Maria");
                encapsulationDemo.SetLastName("Rivera");
                encapsulationDemo.SetGrade(100);
               
                //Printing property's values using Getter Method
                Console.WriteLine("Student Id: {0}", encapsulationDemo.GetStudentId().ToString());
                Console.WriteLine("Name      : {0}", encapsulationDemo.GetLastName().ToString() + ", " + encapsulationDemo.GetFirstName().ToString());
                Console.WriteLine("Grade     : {0}", encapsulationDemo.GetGrade().ToString());

                //Excercise 4. Application 
                //Demonstrates the use of both the `Student` and `Teacher` classes.

                
                Console.WriteLine("\n4. Application");
                Console.WriteLine("\nOther examples of application");

                //Instantiate object from the class Student 
                Student student1 = new Student(28, "Wellington", "Suero", 100); // Uses parameterized constructor
                Console.WriteLine("\nStudent Adding using parameterized constructor of the class Student ");
                Console.WriteLine(student1.ToString());

                //Instantiate object from the class Teacher  
                Console.WriteLine("\nTeacher object was created using parameterized constructor of the class Teacher");
                Teacher teacher2 = new Teacher(1, "Smith", "Jonh", 0, "JavaScript");

                Console.WriteLine("and printing using override ToString() method in the parent class 'Student'");
                Console.WriteLine(teacher2.ToString());

                Console.WriteLine("\nSame Object is printing using the method Teach in the child class Teacher");
                Console.WriteLine(teacher2.Teach());

                Console.ReadKey();
            }
            catch (Exception ex) 
            {
                Console.WriteLine("An error occurred: {0}", ex.Message);
            } 
        }
    }
}
