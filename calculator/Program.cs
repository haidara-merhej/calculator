
while(true)
{
    Console.Write("Enter the first number: ");
    bool isParsedN1 = double.TryParse(Console.ReadLine()!, out double number1);

    if(!isParsedN1)
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    Console.Write("Enter the second number: ");
    bool isParsedN2 = double.TryParse(Console.ReadLine()!, out double number2);

    if(!isParsedN2)
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    if(number2 == 0)
    {
        Console.WriteLine("Division by zero is not allowed. Please enter a valid second number.");
        continue;
    }

    Console.Write("Choose an operator (+, -, *, /): ");
    bool isParsedOp = char.TryParse(Console.ReadLine()!, out char op);

    if(!isParsedOp || (op != '+' && op != '-' && op != '*' && op != '/'))
    {
        Console.WriteLine("Invalid operator. Please enter a valid operator.");
        continue;
    }

    double result = Calculate(number1, number2, op);
    Console.WriteLine($"Result is: {result}");
    Console.Write("press any key to exit...");
    if(Console.ReadKey().Key == ConsoleKey.Enter)
    {
        Console.Clear();
        continue;
    }
    else
        break;
    

}

double Calculate(double number1, double number2, char op)
{
    double result = op switch
    {
        '+' => Add(number1, number2),
        '-' => Subtract(number1, number2),
        '*' => Multiply(number1, number2),
        '/' => Divide(number1, number2),
        _ => 0
    };

    return result;
}

double Add(double number1, double number2) => number1 + number2;

double Subtract(double number1, double number2) => number1 - number2;

double Multiply(double number1, double number2) => number1 * number2;

double Divide(double number1, double number2) => number1 / number2;