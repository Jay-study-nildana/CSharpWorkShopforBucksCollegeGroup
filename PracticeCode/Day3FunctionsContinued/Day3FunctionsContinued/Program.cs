// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Type One
//i wish to write a function that 
//does not take any arguments
//does not return anything. 


//function definition
void FunctionTypeOne() {

    string someString1 = "Hey guys, the Flash movie is not that good";
    Console.WriteLine(someString1);
}

//function call
FunctionTypeOne();

//Type Two
//i wish to write a function that
//that will take single integer parameter
//and does not return anything 

//function definition
void FunctionTypeTwo(int numberofmovies)
{
    string outputSentence = $"I have watched {numberofmovies} movies this year";
    Console.WriteLine(outputSentence);
}

int tobeSentToFunctionMovieCount = 200;

FunctionTypeTwo(tobeSentToFunctionMovieCount);

//function call
FunctionTypeTwo(10);

//same as Type two but with more than one parameter

void FunctionTypeTwoPartB(int one, string two, bool three)
{
    string someOutput = $"The values are {one}, {two}, {three}";
    Console.WriteLine(someOutput);
}

int one = 1;
string two = "two";
bool three = true;

//function call
FunctionTypeTwoPartB(one, two, three);

//Type Three
//a function that is taking some parameters
//and returning some value

//function definition

//function that will add two numbers
int FunctionThatAddsTwoNumbers(int numberOne, int numberTwo)
{
    int sum = numberOne + numberTwo;
    return sum;
}

int doubleooseven = 7;
int randomagent = 50;

//function call

int result = FunctionThatAddsTwoNumbers(doubleooseven, randomagent);

string outputofAgents = $"The sum of {doubleooseven} and {randomagent} is {result}";
Console.WriteLine(outputofAgents);



