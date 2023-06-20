// See https://aka.ms/new-console-template for more information
Console.WriteLine("Simple Calculator!");

# region variable declarations

int someNumber1 = 40;
int someNumber2 = 20;

# endregion

# region function definitions

//function definitions 

// this will do addition
int Add(int num1, int num2)
{
    int sum = num1 + num2;
    return sum;
    
}

// this will do subtraction

int Subtract(int num1, int num2)
{
    int difference = num1 - num2;
    return difference;
}

// this will do multiplication

int Multiply(int num1, int num2)
{
    int product = num1 * num2;
    return product;
}

// this will do division

int Divide(int num1, int num2)
{
    int quotient = num1 / num2;
    return quotient;
}

# endregion

# region function calls

//function calls

// this will call the addition function
int sum = Add(someNumber1, someNumber2);
Console.WriteLine($"The sum of {someNumber1} and {someNumber2} is {sum}");

// this will call the subtraction function

int difference = Subtract(someNumber1, someNumber2);
Console.WriteLine($"The difference of {someNumber1} and {someNumber2} is {difference}");

// this will call the multiplication function

int product = Multiply(someNumber1, someNumber2);
Console.WriteLine($"The product of {someNumber1} and {someNumber2} is {product}");

// this will call the division function

int quotient = Divide(someNumber1, someNumber2);
Console.WriteLine($"The quotient of {someNumber1} and {someNumber2} is {quotient}");

#endregion


