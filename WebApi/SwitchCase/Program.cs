/*int choice = 3;

switch (choice)
{
    case 1:
        Console.WriteLine("1");
        break;

    case 2: 
        Console.WriteLine("2"); 
        break;  
    case 3: 
        Console.WriteLine("3"); 
        break;

}*/


/*int money = 0;
string gender = "male";

switch (gender)
{
    case "male":
        money += 10;
        break;

    case "female":
        money += 10;
        Console.WriteLine("Hello");
        break;
    default:
        break;
}

Console.WriteLine(money);*/


object obj = 10.2;
switch (obj)
{
    case int a: Console.WriteLine("A"); break;
    case double a when a > 12: Console.WriteLine("B"); break;
    default: Console.WriteLine("C"); break;
}



/*int money = 0;
int score = 10;
string str = "Dew";

switch (money)
{
    //แบบนี้ไม่่ได้
    case money > 10:
        money += 10;
        break;

    //อันนี้ก็ไม่ได้
    case score:
        money += 10;
        Console.WriteLine("Hello");
        break;

    case str:
        money += 10;
        Console.WriteLine("Hello");
        break;
    default:
        break;
}

Console.WriteLine(money);*/