// See https://aka.ms/new-console-template for more information
Console.WriteLine($"There is a Magic Number, Can you guess what is it?");
Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);     
            
           int guess;
           int counter = 0; 
do
{
    Console.Write("what is your guess? ");
      guess = int.Parse(Console.ReadLine());

    if (magicNumber > guess)
    {
        Console.WriteLine("Higher");
    }

    else if (magicNumber < guess)
    {
        Console.WriteLine("Lower");
    }

    else
    {
        Console.WriteLine("You Guest it!!");
    }

    counter +=1;

} while (guess != magicNumber);

Console.WriteLine($"It took you {counter} amount of tries to guess");

  Console.WriteLine("Do you want to keep playing? Y/N");
   string keepPlaying = "Y";
   string stopPlaying = "N";
