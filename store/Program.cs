
// int m = int.Parse(n);
// int.TryParse(n, out m);
string choice = "";
int money = 10000;
int cost = 0;

string numberString = "";
int number = 0;


while (money > 0)
{
    Console.WriteLine($"\nyou have {money} gold coins");
    Console.WriteLine("1. Battle axe 5000 coins \n2. book 50 coins \n3. random potion 10 000 coins");

    choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine("how many would you like to buy? ");
        numberString = Console.ReadLine();
        int.TryParse(numberString, out number);
        cost = number * 5000;
         if (cost > money)
        {
            Console.WriteLine("you don't have enough coins");
        }
        else
        {
            money -= cost;
        }

    }
    if (choice == "2")
    {
        Console.WriteLine("how many would you like to buy? ");
        numberString = Console.ReadLine();
        int.TryParse(numberString, out number);
        cost = number * 50;
        if (cost > money)
        {
            Console.WriteLine("you don't have enough coins");
        }
        else
        {
            money -= cost;
        }
        

    }
    if (choice == "3")
    {
        Console.WriteLine("how many would you like to buy? ");
        numberString = Console.ReadLine();
        int.TryParse(numberString, out number);
        cost = number * 10000;
         if (cost > money)
        {
            Console.WriteLine("you don't have enough coins");
        }
        else
        {
            money -= cost;
        }

    }
    while (choice != "1" && choice != "2" && choice != "3")
    {
        Console.WriteLine("choose one of the options above");
        choice = Console.ReadLine();
    }


}

Console.WriteLine("you are broke");

Console.ReadLine();