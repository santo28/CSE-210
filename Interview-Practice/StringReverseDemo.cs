using System;
namespace reverse
{
    public class StringReverseDemo
    {
    public static void reverseWord()
    {
        Console.WriteLine("Write a Word");
      string str = Console.ReadLine();
       

        var chars = str.ToCharArray();
        var length = chars.Length;

        // Console.WriteLine($"String length is: {length}");

        for (var i = length-1; i >= 0; i--)
        {
        Console.Write(chars[i]);         
        }

    }

    }

}

