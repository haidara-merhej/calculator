
while(true)
{
    Console.Write("Enter the first number: ");
    double number1 = double.Parse(Console.ReadLine()!);

    Console.Write("Enter the second number: ");
    double number2 = double.Parse(Console.ReadLine()!);

    Console.Write("Choose an operator (+, -, *, /): ");
    char op = char.Parse(Console.ReadLine()!);

    double result = Calculate(number1, number2, op);
    Console.WriteLine($"Result is: {result}\n");
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