class Input
{
    //method for console user input
    public static void Hello()
    {
        Console.WriteLine("What is your name? ");
        string? username = Console.ReadLine();
        Console.WriteLine("Confirming.... ");
        Thread.Sleep(1000);
        Console.WriteLine("What is your last name? ");
        string? userlastname = Console.ReadLine();
        Console.WriteLine("Confirming.... ");
        Thread.Sleep(1000);
        Console.WriteLine("Printing Response.... "); 
        Thread.Sleep(1000);
        Console.WriteLine("Hello, " + username + " "  +  userlastname + "!");
    }
}