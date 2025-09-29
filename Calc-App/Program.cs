Calculatorapp();
void Calculatorapp()
{
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;
    //Asks user for first value
    Console.WriteLine("Input the first value");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    //Asks user for seocnd value
    Console.WriteLine("Input the second value");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    //loop for relevant operation
    //Will perform the equation
    Console.WriteLine("Choose from this list");
    Console.WriteLine("1- Addition");
    Console.WriteLine("2- Subtraction");
    Console.WriteLine("3- Multiplication");
    Console.WriteLine("4- Division");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} equals {result}");

    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {firstNumber} and {secondNumber} equals {result}");


    }
    else if (choice == 3)
    {
        result = firstNumber * secondNumber; ;
        Console.WriteLine($"Multiplying {firstNumber} and {secondNumber} equals {result}");

    }
    else if (choice == 4)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} and {secondNumber} equals {result}");

    }
    else
    {
        Console.WriteLine("You did not select a valid number between 1-4");

    }
}

