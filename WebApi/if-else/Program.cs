int money = 0;
bool condition1 = true;
bool condition2 = false;

if (condition1)
{
    if (condition2)
    {
        money += 10;
    }
    else 
    {
        money += 5; 
    }
}

Console.WriteLine(money);

Console.WriteLine("/////////////inline if///////////////");

//inline if
// condition ? true-expression:false-expression

int money2 = 0;
string name = "lion";

money2 = name == "lion" ? money2 = 50 : money2 = 100;

Console.WriteLine(money2);
Console.WriteLine("///////////////////////////////////////");