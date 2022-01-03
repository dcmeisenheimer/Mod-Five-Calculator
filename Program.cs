int total = 0;
int userChoice = 0;
StockOwner(userChoice, ref total);
Control(userChoice, ref total);
ManagementStaffing(userChoice, ref total);

static void StockOwner(int userChoice, ref int total)
{
    System.Console.WriteLine("Tokyo Sushi Stock OwnerShip \nInput Total:");
    userChoice = int.Parse(Console.ReadLine());

    if (userChoice >= 25)
    {
        total = (userChoice - 24) * 8;
    }
    else
    {
        total = total - 300;
    }
    System.Console.WriteLine($"Current total is: {total}");
}

static void Control(int userChoice, ref int total)
{
    System.Console.WriteLine("Tokyo Seats on board \nInput Total seats");
    userChoice = int.Parse(Console.ReadLine());

    if (userChoice >= 3)
    {
        total = total + ((userChoice - 2) * 10);
    }
    else
    {
        total = total - 100;
    }
    System.Console.WriteLine(total);
}

static void ManagementStaffing(int userChoice, ref int total)
{
    System.Console.WriteLine(userChoice);
    System.Console.WriteLine(total);
}

