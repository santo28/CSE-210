// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a list of numbers, type 0 when finished");

 List<int> numbers = new List<int>();

 int userNumber;
    userNumber = 1;

while (userNumber != 0)
            {
                Console.Write("Enter a number: ");
                
                string userResponse = Console.ReadLine();
                userNumber = int.Parse(userResponse);
                
                numbers.Add(userNumber);
            }

int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}


