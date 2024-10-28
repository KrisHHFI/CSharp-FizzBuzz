/*
A simple C# "Fizz Buzz" program
*/
Console.WriteLine("Fizz Buzz - - - - -");

for (int i = 1; i <= 100; i++)
{
    // If a multiple of 3 and 5 "Fizz Buzz"
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine("FizzBuzz");
    }
    // If divisible by 3 "Fizz"
    if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    // If a multiple of 5 "Buzz"
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}