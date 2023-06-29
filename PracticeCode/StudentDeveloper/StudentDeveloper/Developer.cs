using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDeveloper
{
    public class Developer
    {
        //constructor to assign default values
        public Developer()
        {
            Console.WriteLine(" hey guys this constructor has been called");

            this.TotalNumberofHoursToBecomeDeveloper = 500;
        }

        //fields or properties for this class
        public int TotalNumberofHoursToBecomeDeveloper { set; get; }
        public string outputforStudent { set; get; }

        public void CalculatorDeveloperEstimate(int StudyHoursPerWeek, int StudyWeeksCompleted, string NameOfStudent)
        {
            int numberOfWeeksBasedOnStudentWeeklyHoursCommitment =
    this.TotalNumberofHoursToBecomeDeveloper / StudyHoursPerWeek;

            int remainingnumberOfWeeksToStudy =
    numberOfWeeksBasedOnStudentWeeklyHoursCommitment - StudyWeeksCompleted;

            this.outputforStudent = $" Student Name : {NameOfStudent} will need to study for {remainingnumberOfWeeksToStudy} weeks to become a basic beginner developer";
        }

        public void DisplayDeveloperEstimate()
        {
            Console.WriteLine(this.outputforStudent);
        }
    }
}
