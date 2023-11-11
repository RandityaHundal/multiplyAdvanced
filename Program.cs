//main code

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