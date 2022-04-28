// See https://aka.ms/new-console-template for more information

Console.WriteLine("enter first number");
   int x = int.Parse(Console.ReadLine());

Console.WriteLine("enter second number");
   int y = int.Parse(Console.ReadLine());

Console.WriteLine("enter third number");
   int  z = int.Parse(Console.ReadLine());

int result1 = (x+y) * z;
int result2 = x*y + y*z;

    Console.WriteLine($"Output1: ({x} + {y}) x {z} = {result1}");
    Console.WriteLine($"Output2: ({x} + {y}) x {z} = {result2}");



