using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StudentDeveloper
{
    public class Student
    {
        //fields or properties or variables

        public int StudyHoursPerWeek { get; set; }

        public int StudyWeeksCompleted { get; set; }

        public string NameOfStudent { get; set; }

        //for the sake of the output
        public string OutputStorage { get; set; }

        //functions or methods or behaviors or actions 

        public void BuildStudentInformation()
        {
            this.OutputStorage = $" Student Name : {this.NameOfStudent} Study Hours : {this.StudyHoursPerWeek} Number of Weeks Completed : {this.StudyWeeksCompleted}";
        }

        public void DisplayStudentInformation()
        {
            Console.WriteLine(this.OutputStorage);
        }
    }
}
