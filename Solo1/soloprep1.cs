// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

string first;
string last;

Console.WriteLine("what is your first name?");
 first = Console.ReadLine();

Console.WriteLine("what is your last name?");
 last = Console.ReadLine();

Console.WriteLine($"Your name is {last}, {first} {last}.");
        }
    }
}

