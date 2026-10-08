
// int m = int.Parse(n);
// int.TryParse(n, out m);
using System.Diagnostics;

string choice = "";
int money = 10000;
int cost = 0;

int rnd = Random.Shared.Next(3);

string numberString = "";
int number = 0;


while (money > 0)
{
    Console.WriteLine($"\nyou have {money} gold coins");
    Console.WriteLine("what would you like to buy?");
    Console.WriteLine("1. Battle axe 5000 coins \n2. book 50 coins \n3. random potion 10 000 coins");

    choice = Console.ReadLine();

    while (choice != "1" && choice != "2" && choice != "3")
    {
        Console.WriteLine("choose one of the options above");
        choice = Console.ReadLine();
    }

    if (choice == "1")
    {
        Console.WriteLine("how many would you like to buy? ");
        numberString = Console.ReadLine();

          
        while (!int.TryParse(numberString, out number))
        {
            Console.WriteLine("This is a string\nPlease write a number");
            numberString = Console.ReadLine();
        }
        
        while (number < 0)
        {
            Console.WriteLine("The number has to be positive\n please write a different number");
            numberString = Console.ReadLine();
            int.TryParse(numberString, out number);



        }
        cost = number * 5000;
        
         if (cost > money)
        {
            Console.WriteLine("you don't have enough coins");
        }
        else
        {
            money -= cost;
            Console.WriteLine("yes that works.");
            Console.WriteLine($"You have {money} coins left");
        }

    }

    if (choice == "2")
    {
        Console.WriteLine("how many would you like to buy? ");
        numberString = Console.ReadLine();
        
  
        while (!int.TryParse(numberString, out number))
        {
            Console.WriteLine("This is a string\nPlease write a number");
            numberString = Console.ReadLine();
        }

        while (number < 0)
        {
            Console.WriteLine("The number has to be positive\n pleas write a different number");
            numberString = Console.ReadLine();
            int.TryParse(numberString, out number);
        }
        cost = number * 50;
        if (cost > money)
        {
            Console.WriteLine("you don't have enough coins");
        }
        else
        {
            money -= cost;
            Console.WriteLine("Yes that works.");
            Console.WriteLine($"You have {money} coins left");
        }
        

    }
    if (choice == "3")
    {
        Console.WriteLine("how many would you like to buy? ");
        numberString = Console.ReadLine();
        
  
        while (!int.TryParse(numberString, out number))
        {
            Console.WriteLine("This is a string\nPlease write a number");
            numberString = Console.ReadLine();
        }

        while (number < 0)
        {
            Console.WriteLine("The number has to be positive\n pleas write a different number");
            numberString = Console.ReadLine();
            int.TryParse(numberString, out number);
        }
        cost = number * 10000;
         if (cost > money)
        {
            Console.WriteLine("you don't have enough coins");
        }
        else
        {
            money -= cost;
            Console.WriteLine("Yes that works.");
            rnd = Random.Shared.Next(3);

            if (rnd == 0)
            {
               Console.WriteLine("You got a potion of night vison "); 
            }
            if (rnd == 1)
            {
               Console.WriteLine("You got a potion of invisibility"); 
                
            }
            if (rnd == 2)
            {
                
               Console.WriteLine("You got a potion of fire resistance"); 
            }

            Console.WriteLine($"You have {money} coins left");
        }

    }
    


}

Console.WriteLine("you are broke, press enter to exit");

Console.ReadLine();