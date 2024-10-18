

Console.WriteLine("Please Enter Your Name");

string name = Console.ReadLine();


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Please enter a number between 1 and 100 inclusive");

    int input = Convert.ToInt32(Console.ReadLine());

    if (input % 2 != 0 && input < 60)
    {
        Console.WriteLine(name + ", you entered " + input + " - that number is Odd and less than 60.");
    }
    else if (input % 2 == 0 && input >= 2 && input <= 24)
    {
        Console.WriteLine(name + ", you entered " + input + " - that number is Even and less than 25.");
    }
    else if (input % 2 == 0 && input >= 26 && input <= 60)
    {
        Console.WriteLine(name + ", you entered " + input + " - that number is Even and between 26 and 60 inclusive.");
    }
    else if (input % 2 == 0 && input > 60)
    {
        Console.WriteLine(name + ", you entered " + input + " - that number is Even and greater than 60.");
    }
    else if (input % 2 != 0 && input > 60)
    {
        Console.WriteLine(name + ", you entered " + input + " - that number is Odd and greater than 60.");
    }
}