// See https://aka.ms/new-console-template for more information


using StudentDeveloper;

Console.WriteLine("Hello, World!");

//student called Bruce Wayne 

Student BruceWayne = new Student();
Student SelinaKyle = new Student();

BruceWayne.NameOfStudent = "Bruce Wayne";
BruceWayne.StudyHoursPerWeek = 20;
BruceWayne.StudyWeeksCompleted = 0;

BruceWayne.BuildStudentInformation();
BruceWayne.DisplayStudentInformation();

SelinaKyle.NameOfStudent = "Selina Kyle";
SelinaKyle.StudyHoursPerWeek = 10;
SelinaKyle.StudyWeeksCompleted = 10;

SelinaKyle.BuildStudentInformation();
SelinaKyle.DisplayStudentInformation();

# region 

//string outputForBatman = $" Student Name : {BruceWayne.NameOfStudent} Study Hours : {BruceWayne.StudyHoursPerWeek} Number of Weeks Completed : {BruceWayne.StudyWeeksCompleted}";

//string outputForCatwoman = $" Student Name : {SelinaKyle.NameOfStudent} Study Hours : {SelinaKyle.StudyHoursPerWeek} Number of Weeks Completed : {SelinaKyle.StudyWeeksCompleted}";

//Console.WriteLine(outputForBatman);
//Console.WriteLine(outputForCatwoman);

#endregion

//super hero guy called The Phantom

Student KitWalker = new Student();

KitWalker.NameOfStudent = "Kit Walker";
KitWalker.StudyHoursPerWeek = 30;
KitWalker.StudyWeeksCompleted = 30;

KitWalker.BuildStudentInformation();
KitWalker.DisplayStudentInformation();

//500 hours is the amount of time it takes to become
//a beginner developer.

int TotalNumberofHoursToBecomeDeveloper = 500;

//20 hours per week
//25 weeks to become a beginner developer.
//number of weeks already completed is 0
//remaining weeks = 25 - 0 = 25 weeks
//ultimately, batman will become a developer in 25 weeks.

//10 hours per week
//50 weeks to become a beginner developer
//10 weeks are already completed
//remaining weeks = 50 - 10 = 40 weeks.
//eventually, catwoman will be a developer in 40 weeks. 


int numberOfWeeksBasedOnStudentWeeklyHoursCommitment =
    TotalNumberofHoursToBecomeDeveloper / BruceWayne.StudyHoursPerWeek;

//Console.WriteLine(numberOfWeeksBasedOnStudentWeeklyHoursCommitment);

int remainingnumberOfWeeksToStudy = 
    numberOfWeeksBasedOnStudentWeeklyHoursCommitment - BruceWayne.StudyWeeksCompleted;

//Console.WriteLine(remainingnumberOfWeeksToStudy);

string outputforBatmanStudent = $" Student Name : {BruceWayne.NameOfStudent} will need to study for {remainingnumberOfWeeksToStudy} weeks to become a basic beginner developer";

Console.WriteLine(outputforBatmanStudent);

//here, I want to start using the Developer class

Developer DeveloperTesting = new Developer();



