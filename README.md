# Multiplication Program

This is a simple console application written in C# that multiplies two numbers and determines if the result is even or odd.

## How to Run

1. Clone the repository to your local machine.
2. Open the solution in JetBrains Rider.
3. Run the program.

## Program Flow

1. The program will first ask for two numbers to be multiplied.
2. It will then multiply the numbers and determine if the result is even or odd.
3. The result and its status (even or odd) will be displayed.

## Code Snippet

```csharp
Console.WriteLine("insert 2 numbers to be multiplied");
int num1 = Convert.ToInt16(Console.ReadLine());
int num2 = Convert.ToInt16(Console.ReadLine());

int result = Multiply(num1,num2);

string numStatus = "tbd";

if (result % 2 == 0)
{
    numStatus = "even";
}
else
{
    numStatus = "odd";
}

Console.WriteLine($"The result is {result} and it is an {numStatus} number.");

// close with key
Console.ReadKey();

// multiply function

static int Multiply(int num1, int num2)
{
    int result = num1 * num2;
    return result;
}
