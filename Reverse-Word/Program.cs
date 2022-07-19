// See https://aka.ms/new-console-template for more information

Console.WriteLine("Write a Word: ");
string str = Console.ReadLine();

 var chars = str;
 var Length = chars.Length;

for (var i = Length-1 ; i>=0 ; i-- ){
     Console.Write(chars[i]);
}



