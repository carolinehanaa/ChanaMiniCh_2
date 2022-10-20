
Console.Clear();
string? playAgain = "yes";
while (playAgain == "yes")
{

    string? input1, input2;
    int number1, number2, sum;

    Console.Write("Put a number: ");
    input1 = Console.ReadLine();

    Console.Write("Put another number: ");
    input2 = Console.ReadLine();

    bool validnum1 = int.TryParse(input1, out number1);
    bool validnum2 = int.TryParse(input2, out number2);

    if (!validnum1 || !validnum2)
    {
        Console.WriteLine("Invalid Number");
        playAgain = "yes";
    }

    else if (validnum1 && validnum2)
    {
        sum = number1 + number2;
        Console.WriteLine($"{number1} + {number2} = {sum}");
    }

    string? answer = "";
    while (answer != "yes" && answer != "no")
    {
        Console.WriteLine("Would you like to play again? (yes or no)");
        answer = Console.ReadLine();
        answer = answer.ToLower();
        if (answer == "yes")
        {
            playAgain = answer;
        }
        else if (answer == "no")
        {
            playAgain = answer;
        }
        else
        {
            Console.WriteLine("Invalid Answer");
        }

    }


}