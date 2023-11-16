// See https://aka.ms/new-console-template for more information

/*Console.WriteLine("input your name");
string input = Console.ReadLine();
Console.WriteLine("Hello " + input);*/

//gender input
/*Console.WriteLine("What's your gender? male or female");
string input = Console.ReadLine();
if (input == null)
{
    Console.WriteLine("please input something");
}
else if (input == "male")
{
    Console.WriteLine("Hello boy");
}
else if (input == "female")
{
    Console.WriteLine("Hello Gril");
}
else
{
    Console.WriteLine("Only male or female accept");
}*/

//grade 

/*int wrongStack = 0;
bool condition = true;

while (condition)
{
    Console.WriteLine("WrongStack = " + wrongStack);
    if (wrongStack >= 3)
    {
        condition = false;
    }

    try
    {
        Console.Write("Please input your score : ");
        string input = Console.ReadLine();
        int score = (int) double.Parse(input);
        string grade = "";
        Console.WriteLine("");

        if (score > 100)
        {
            grade = "You input over score";
        }
        else if (score >= 90)
        {
            grade = "Grade A";
        }
        else if (score >= 80)
        {
            grade = "Grade B";
        }
        else if (score >= 70)
        {
            grade = "Grade C";
        }
        else if (score >= 60)
        {
            grade = "Grade D";
        }
        else if (score < 60)
        {
            grade = "Grade F";
        }
        else
        {
            grade = "Invalid Input";
        }

        Console.WriteLine(grade);
        Thread.Sleep(1000);
    }
    catch (FormatException)
    {
        Console.WriteLine("Please Input Number Only");
        Console.WriteLine(wrongStack);
        wrongStack += 1;

        Thread.Sleep(1000);
    }

    Console.Clear();
}
*/


// if-else-fruit-sale

/*//user input money amount ex.100
Console.Write("How many money do you have? ");
string moneyInput = Console.ReadLine();
int money = (int) double.Parse(moneyInput);
//user pick fruit ex.Orange
Console.Write("Which one do you want to buy Orange or Lemon? ");
string fruitInput = Console.ReadLine();
int costPerPice = 0;
if (fruitInput == "Orange")
{
    costPerPice = 20;
}
else if (fruitInput == "Lemon")
{
    costPerPice = 30;    
}
//user input fruit amount ex.20
Console.Write("How much ");
int FruitAmount = (int)double.Parse(Console.ReadLine());
//user got change ex.20 or not enough money!
int FruitCost = money - (costPerPice * FruitAmount);
if (FruitCost >= 0)
{
    //Here your change (moneyInput - (costPerPice * FruitAmount))
    Console.WriteLine("Here your change " + FruitCost);
}
//else 
else
{
    //You have not enough money!
    Console.WriteLine("You have not enough money!");
}*/


