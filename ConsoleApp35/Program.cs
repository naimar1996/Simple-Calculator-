Console.WriteLine("--------");
double number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------");
double number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter symbols(+,-,*,/");
string operations = Console.ReadLine();
switch (operations)
{
    case "+":
        int sum;
        Console.WriteLine(number1 + number2);
        break;
    case "-":
        int con;
        Console.WriteLine(number1 - number2);
        break;
    case "*":
        int time;
        Console.WriteLine(number1 * number2);
        break;
    case "/":
        int division;
        Console.WriteLine(number1 / number2);
        break;
    default:
        Console.WriteLine("Try again");
        break;
}

 



