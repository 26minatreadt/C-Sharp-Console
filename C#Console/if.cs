public class If
{
    public static void Number() {
        Console.WriteLine("Randomizing Numbers..... ");
        //randomises a number between 0 and 100
        Random random = new Random();
        int number = random.Next(-100, 100);
        Thread.Sleep(5000);
        Console.WriteLine(number);
        Thread.Sleep(1000);
        Console.WriteLine("Number Randomized! ");
        Thread.Sleep(1000);

        //sets the number the random number as an integer
        int numberInt = Convert.ToInt32(number);
        Console.WriteLine("Double Checking..... ");
        //asks user if they want to regenerate the number
        Console.WriteLine("Do you want to re-generate the number? (y/n)");
        string? userInput = Console.ReadLine();
        //checks if the user wants to re-generate the number
        if (userInput == "y")
            {
                //restarts script
                Number();
                return;
            }
        else
            {
                //continues code
                Console.WriteLine("Continuing with the current number.");
            }
        
        Thread.Sleep(1500);
        Console.WriteLine("Generating Result..... ");
        Thread.Sleep(1000);
        //checks if the number is greater than 0 | or checks positive
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
            s();
        }

        //checks if the number is less than 0 | or checks negative
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
            yes();
        }

        
    }
    public static void yes() {
        Console.WriteLine("Do you want to continue? (y/n)");
        string? userInput = Console.ReadLine();
        if (userInput == "y")
        {
            Number();
        }
        else
        {
            Console.WriteLine("Goodbye!");
        }
    }
    public static void s()
    {
        //write code to congratulate the user
        Console.WriteLine("Congratulations! You guessed correctly!");
        Console.WriteLine("Do you want to continue? (y/n)");
        string? userInput = Console.ReadLine();
        if (userInput == "y")
        {
            Number();
        }
        else
        {
            Console.WriteLine("Goodbye!");
        }
    }
}