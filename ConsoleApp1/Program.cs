Console.WriteLine ("Name: ");
String name = Console.ReadLine();

if (name == "Bao")
{
    Console.WriteLine("Welcome!");
    
}
Console.WriteLine ("Age: "); 
String age = Console.ReadLine();

int x = 18;


if (x > 18 && x == 18) {

Console.WriteLine("You are legal, Access accepted!");
}
else     {
  Console.WriteLine("You are not legal, Access denied!");

}

Console.WriteLine ("Choose a random number between 1 to 6");
String randomNumber = Console.ReadLine();

Random random = new Random();
int dice = random.Next(1, 7);

Console.WriteLine("TThe Dice result is: ");
Console.WriteLine(dice);

if (dice == Convert.ToInt32(randomNumber)) 

 
 {
    Console.WriteLine("Congratulations! You guessed correctly!");
 }
 else     {
  Console.WriteLine("Sorry, you guessed incorrectly!");

}
Console.ReadLine();