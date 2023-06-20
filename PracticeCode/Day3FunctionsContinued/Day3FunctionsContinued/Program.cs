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

FunctionTypeTwo(10);

