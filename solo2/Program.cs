
Console.WriteLine($"What is your grade percentage?");
String response = Console.ReadLine();
int number = int.Parse(response);

string letter = "";

if (number >= 90)
{
    letter = "A";
}
else if (number >= 80)
{
    letter = "B";
}

else if (number >= 70)
{
    letter = "C";
}
else if (number >= 60)
{
    letter = "D";
}

else
{
    letter = "F";
}

Console.WriteLine($"Your grade is: {letter}");

if (number >= 70)
    Console.WriteLine($"You passed the Class");

else 
{
Console.WriteLine($"You can do better next time");
}