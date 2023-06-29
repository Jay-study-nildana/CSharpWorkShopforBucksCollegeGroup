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

            //for example, suppose the output is 25 weeks.
            //that is roughly 5 months. 

            int numberofMonths = 0;

            while(remainingnumberOfWeeksToStudy > 4)
            {
                numberofMonths = numberofMonths + 1;
                remainingnumberOfWeeksToStudy =
                    remainingnumberOfWeeksToStudy - 4;
            }

            this.outputforStudent = $" Student Name : {NameOfStudent} will need to study for {numberofMonths} months to become a basic beginner developer";
        }

        public void DisplayDeveloperEstimate()
        {
            Console.WriteLine(this.outputforStudent);
        }
    }
}
