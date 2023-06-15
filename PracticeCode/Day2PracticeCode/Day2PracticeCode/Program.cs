// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//two variables that hold two numbers

int num1 = 5;
int num2 = 10;

//use the addition operator on these two numbers

int sum = num1 + num2;

//print the sum to the console

Console.WriteLine(sum);
string fancyoutputsum = $"{num1} + {num2} = {sum}";
Console.WriteLine(fancyoutputsum);

//use the subtraction operator on these two numbers

int difference = num1 - num2;

//print the difference to the console

string fancyoutputdifference = $"{num1} - {num2} = {difference}";
Console.WriteLine(fancyoutputdifference);

//use the multiplication operator on these two numbers

int product = num1 * num2;

//print the product to the console

string fancyoutputproduct = $"{num1} * {num2} = {product}";

Console.WriteLine(fancyoutputproduct);

//use the division operator on these two numbers

int quotient = num1 / num2;

//print the quotient to the console

string fancyoutputquotient = $"{num1} / {num2} = {quotient}";

Console.WriteLine(fancyoutputquotient);



////lets do the same thing with functions
///

int numberOneForFunctions = 5;
int numberTwoForFunctions = 10;

//Function Definition
//testing comments

int AddTwoNumbers(int num1, int num2)
{
    int sum = num1 + num2;
    return sum;
}

//Function Call

int storeResultOfAddTwoNumbersFunctionCall = AddTwoNumbers(numberOneForFunctions, numberTwoForFunctions);

string fancyoutputforstoreResultOfAddTwoNumbersFunctionCall = $"{numberOneForFunctions} + {numberTwoForFunctions} = {storeResultOfAddTwoNumbersFunctionCall}";

Console.WriteLine(fancyoutputforstoreResultOfAddTwoNumbersFunctionCall);

int storeResultOfAddTwoNumbersFunctionCall2 = AddTwoNumbers(100, 200);
int storeResultOfAddTwoNumbersFunctionCall3 = AddTwoNumbers(1000, 200);
int storeResultOfAddTwoNumbersFunctionCall4 = AddTwoNumbers(166, 200);
int storeResultOfAddTwoNumbersFunctionCall5 = AddTwoNumbers(188, 200);
int storeResultOfAddTwoNumbersFunctionCall6 = AddTwoNumbers(190, 200);
int storeResultOfAddTwoNumbersFunctionCall7 = AddTwoNumbers(16454, 200);
int storeResultOfAddTwoNumbersFunctionCall8 = AddTwoNumbers(1443, 200);

Console.WriteLine(storeResultOfAddTwoNumbersFunctionCall2);
Console.WriteLine(storeResultOfAddTwoNumbersFunctionCall3);
Console.WriteLine(storeResultOfAddTwoNumbersFunctionCall4);
Console.WriteLine(storeResultOfAddTwoNumbersFunctionCall5);
    Console.WriteLine(storeResultOfAddTwoNumbersFunctionCall6);
    Console.WriteLine(storeResultOfAddTwoNumbersFunctionCall7);
    Console.WriteLine(storeResultOfAddTwoNumbersFunctionCall8);
    
