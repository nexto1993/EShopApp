using CSharpAdvancedConcepts.Extensions;

int percentage = -10;
if (percentage.isBetween(0, 100))
{
    Console.WriteLine("Percentage is between 0 and 100");
}
else
{
    Console.WriteLine("Percentage is not between 0 and 100");
}

var str = "Hello World";
Console.WriteLine(str.RemoveSpaces().ReverseString());