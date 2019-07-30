using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 12.7, 10.3, 6.11,4.1 }; // Syntax to create an array or a List
            grades.Add(56.1); // Add new value into grades
            

            var result = 0.0; // set result to 0

            foreach(var number in grades){ // loop through grades with variable number 
                result += number; // iterates through loop based on how many indexes are in grades varable
            }
            result /= grades.Count; // this is the average of result/grades
            Console.WriteLine($"The average grades is {result:N1}"); // Console log result
            
        }
    }
}
