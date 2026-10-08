//Milena Aquino Ramos 2026-1036 :)

int choose=0;
Console.WriteLine("<<<<<WELCOME TO MY PROGRAM!>>>>>\n" +
"I AM MILENA AND I HOPE YOU ENJOY MY PROGRAM <3!!");
try
{
    while (choose != 3)
    {
        Console.WriteLine("---------------------------\n" +
        $"1. Use the calculator.\n" +
        $"2. Calculate your grades.\n" +
        $"3. Exit.\n" +
        "Choose what you want to do:");
        while (!int.TryParse(Console.ReadLine(), out choose)
           || choose < 1
           || choose > 3)
        {
            Console.WriteLine("Invalid option. Please choose 1, 2 or 3: ");
        }

        switch (choose)
        {

            case 1:

                {
                    Console.WriteLine("You chose calculator!\n" +
            $"1. Addition.\n" +
            $"2. Subtraction.\n" +
            $"3. Multiplication.\n" +
            $"4. Division.\n" +
            $"5. Return.\n"+
            "Select the option you need:)");

                    int operation = 0;
                    while (!int.TryParse(Console.ReadLine(), out operation)
           || operation < 1
           || operation > 5)
                    {
                        Console.WriteLine("Invalid option. Please choose the number of the operation: ");
                    }

                    switch (operation)

                    {
                        case 1:

                            {
                                // addition
                                decimal firstnumad;
                                decimal secondnumad;
                                decimal numberad;
                                decimal resultad;
                                string answersad;

                                Console.WriteLine("Enter first number:");

                                while (!decimal.TryParse(Console.ReadLine(), out firstnumad))
                                {
                                    Console.WriteLine("Invalid number. Please try again:");
                                }

                                Console.WriteLine("Enter second number:");

                                while (!decimal.TryParse(Console.ReadLine(), out secondnumad))
                                {
                                    Console.WriteLine("Invalid number. Please try again:");
                                }

                                resultad = firstnumad + secondnumad;


                                do
                                {
                                    Console.WriteLine($"Current result: {resultad}\n" +
                                    "Do you want to add another number? y/n");

                                    answersad = Console.ReadLine()!.ToLower();

                                    while (answersad != "y" && answersad != "n")
                                    {
                                        Console.WriteLine("Invalid option. Please write y/n (yes or no):");
                                        answersad = Console.ReadLine()!.ToLower();
                                    }

                                    if (answersad == "y")
                                    {
                                        Console.WriteLine("Enter another number:");

                                        while (!decimal.TryParse(Console.ReadLine(), out numberad))
                                        {
                                            Console.WriteLine("Invalid number. Please try again:");
                                        }

                                        resultad += numberad;
                                    }
                                }
                                while (answersad == "y");
                                Console.WriteLine($"Result: {resultad}\n" +
                                    "Returning to main menu...\n"+
                                    "---------------------------\n");
                                break;
                            }

                        case 2:

                            {
                                // subtraction
                                decimal firstnumsub;
                                decimal secondnumsub;
                                decimal numbersub;
                                decimal resultsub;
                                string answersub;

                                Console.WriteLine("Enter first number:");

                                while (!decimal.TryParse(Console.ReadLine(), out firstnumsub))
                                {
                                    Console.WriteLine("Invalid number. Please try again:");
                                }

                                Console.WriteLine("Enter second number:");

                                while (!decimal.TryParse(Console.ReadLine(), out secondnumsub))
                                {
                                    Console.WriteLine("Invalid number. Please try again:");
                                }

                                resultsub = firstnumsub - secondnumsub;

                                do
                                {
                                    Console.WriteLine($"Current result: {resultsub}\n" +
                                    "Do you want to subtract another number? y/n");

                                    answersub = Console.ReadLine()!.ToLower();

                                    while (answersub != "y" && answersub != "n")
                                    {
                                        Console.WriteLine("Invalid option. Please write y/n (yes or no):");
                                        answersub = Console.ReadLine()!.ToLower();
                                    }

                                    if (answersub == "y")
                                    {
                                        Console.WriteLine("Enter another number:");

                                        while (!decimal.TryParse(Console.ReadLine(), out numbersub))
                                        {
                                            Console.WriteLine("Invalid number. Please try again:");
                                        }

                                        resultsub -= numbersub;
                                    }

                                }
                                while (answersub == "y");
                                Console.WriteLine($"Result: {resultsub}\n" +
                                    "Returning to main menu...\n" +
                                    "---------------------------\n");
                                break;
                            }

                        case 3:

                            {
                                // multiplication
                                decimal firstnummul;
                                decimal secondnummul;
                                decimal numbermul;
                                decimal resultmul;
                                string answersmul;

                                Console.WriteLine("Enter first number:");

                                while (!decimal.TryParse(Console.ReadLine(), out firstnummul))
                                {
                                    Console.WriteLine("Invalid number. Please try again:");
                                }

                                Console.WriteLine("Enter second number:");

                                while (!decimal.TryParse(Console.ReadLine(), out secondnummul))
                                {
                                    Console.WriteLine("Invalid number. Please try again:");
                                }

                                resultmul = firstnummul * secondnummul;


                                do
                                {
                                    Console.WriteLine($"Current result: {resultmul}\n" +
                                    "Do you want to multiply another number? y/n");

                                    answersmul = Console.ReadLine()!.ToLower();

                                    while (answersmul != "y" && answersmul != "n")
                                    {
                                        Console.WriteLine("Invalid option. Please write y/n (yes or no):");
                                        answersmul = Console.ReadLine()!.ToLower();
                                    }

                                    if (answersmul == "y")
                                    {
                                        Console.WriteLine("Enter another number:");

                                        while (!decimal.TryParse(Console.ReadLine(), out numbermul))
                                        {
                                            Console.WriteLine("Invalid number. Please try again:");
                                        }

                                        resultmul *= numbermul;
                                    }

                                }
                                while (answersmul == "y");

                                Console.WriteLine($"Result: {resultmul}\n" +
                                    "Returning to main menu...\n" +
                                    "---------------------------\n");
                                break;
                            }

                        case 4:

                            {
                                // division
                                decimal firstnumdiv;
                                decimal secondnumdiv;
                                decimal numberdiv;
                                decimal resultdiv;
                                string answerdiv;

                                Console.WriteLine("Enter first number:");

                                while (!decimal.TryParse(Console.ReadLine(), out firstnumdiv))
                                {
                                    Console.WriteLine("Invalid number. Please try again:");
                                }

                                Console.WriteLine("Enter second number:");

                                while (!decimal.TryParse(Console.ReadLine(), out secondnumdiv)
                                       || secondnumdiv == 0)
                                {
                                    Console.WriteLine("Invalid number. Division by zero is not allowed:");
                                }

                                resultdiv = firstnumdiv / secondnumdiv;

                                do
                                {
                                    Console.WriteLine($"Current result: {resultdiv}\n" +
                                    "Do you want to divide by another number? y/n");

                                    answerdiv = Console.ReadLine()!.ToLower();

                                    while (answerdiv != "y" && answerdiv != "n")
                                    {
                                        Console.WriteLine("Invalid option. Please write y/n (yes or no):");
                                        answerdiv = Console.ReadLine()!.ToLower();
                                    }

                                    if (answerdiv == "y")
                                    {
                                        Console.WriteLine("Enter another number:");

                                        while (!decimal.TryParse(Console.ReadLine(), out numberdiv)
                                               || numberdiv == 0)
                                        {
                                            Console.WriteLine("Invalid number. Division by zero is not allowed:");
                                        }

                                        resultdiv /= numberdiv;
                                    }
                                }
                                while (answerdiv == "y");

                                Console.WriteLine($"Result: {resultdiv}\n" +
                                    "Returning to main menu...\n" +
                                    "---------------------------\n");
                                break;
                            }

                        case 5:
                            // return
                            Console.WriteLine("Returning to main menu...\n"+
                             "---------------------------\n");
                            break;
                    }
                    break;
                }

            case 2:
                {
                    Console.WriteLine("You chose Grades!\n");
                    int quantitygrades;
                    decimal grade;
                    decimal totalGrades = 0;
                    decimal average;

                    Console.WriteLine("How many grades do you want to enter?");
                    while (!int.TryParse(Console.ReadLine(), out quantitygrades)
                    || quantitygrades < 2
                    || quantitygrades > 30)
                    {
                        Console.WriteLine("Invalid option. Please enter a valid quantity: ");
                    }

                    for (int i = 1; i <= quantitygrades; i++)
                    {
                        Console.WriteLine($"Enter grade {i}:");

                        while (!decimal.TryParse(Console.ReadLine(), out grade)
                        || grade < 0
                        || grade > 100)
                        {
                            Console.WriteLine("Invalid grade. Please enter a value between 0 and 100:");
                        }

                        totalGrades += grade;
                    }

                    average = totalGrades / quantitygrades;
                    Console.WriteLine($"Your average is: {average}\n");

                    if (average == 100)
                    {
                        Console.WriteLine("Excellent!");
                    }
                    else if (average >= 90)
                    {
                        Console.WriteLine("Congratulations!");
                    }
                    else if (average >= 80)
                    {
                        Console.WriteLine("Good job!");
                    }
                    else if (average >= 70)
                    {
                        Console.WriteLine("You passed!");
                    }
                    else
                    {
                        Console.WriteLine("You failed. Keep trying!");
                    }

                    Console.WriteLine("Returning to main menu...\n" +
                     "---------------------------\n");

                    break;
                }
            case 3:
                {
                    Console.WriteLine("YOU CHOSE EXIT!\n" +
            "THANK YOU FOR USING MY PROGRAM, XOXO!!!");
                }
                break;
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    Console.WriteLine("Close connection.");
}