
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

string ans;
do
{
    Console.WriteLine("Hello. Lets play a dice rolling game. How many sides do you want the pair of dice to have? Enter a number under 7.");
    int sides = int.Parse(Console.ReadLine());

    int RollDice;

    Random random = new Random();
    int returnValue = random.Next(1, sides);
    int returnValue2 = random.Next(1, sides);
    RollDice = 0;
    int total;
    total = returnValue + returnValue2;


    while (sides == 6)
    {
        if (total == 7 || total == 11)
        { Console.WriteLine("YOU WON"); }
        else if (total == 2 || total == 3 || total == 12)
        {
            Console.WriteLine("CRAPS");
        }
        else if (returnValue == 1 && returnValue2 == 1)
        { Console.WriteLine("SNAKE EYES"); }
        else if (returnValue == 1 && returnValue2 == 2)
        { Console.WriteLine("ACE DEUCE"); }
        else if (returnValue == 2 && returnValue2 == 1)
        { Console.WriteLine("ACE DEUCE"); }
        else if (returnValue == 6 && returnValue2 == 6)
        { Console.WriteLine("BOX CARS"); }
    }

        Console.WriteLine($" You rolled a {returnValue} and a {returnValue2}, with a total of {total}");
        Console.WriteLine("Would you like to replay? (y/n)");
        ans = Console.ReadLine();
        if (ans == "y")
        { continue; }

    
    

   

}
while
    (ans != "n");