  class Loops
  {
    public static void ForLoops()
    {
        
        Console.WriteLine("Counting Now.....");
        int i;
        for (i = 1; i <= 10; i++) //starts the counting
        {
            Console.WriteLine("ITERATION" + " " + i);
            Thread.Sleep(100); //slight pause so it doesnt spam to fast
        }
        
        //if statement to check if it the for loop stopped
        if (i > 10)
        {
            Thread.Sleep(500);
            Console.WriteLine("Counting Finished");
            Thread.Sleep(500);
            Console.WriteLine("Proceeding to Count to 20 With Even Numbers.....");
            Thread.Sleep(500);
            EvenLoops(); //starts the even loop that counts to 20 with even numbers only
        }
    }

    public static void EvenLoops()
    {
        Console.WriteLine("Counting To 20 Now With Even Numbers Only.....");
        Thread.Sleep(1000);
        int i;
        for (i = 1; i <= 20; i++) //starts the counting
        {
            if(i % 2 == 0) //checks if they are even
            Console.WriteLine("EVEN ITERATION" + " " + i); 
            Thread.Sleep(100); //slight pause so it doesnt spam to fast
        }
        
        //if statement to check if it the for loop stopped
        if (i > 20)
        {
            Thread.Sleep(500);
            Console.WriteLine("Counting Finished");
            Thread.Sleep(500);
            Console.WriteLine("Proceeding to Count to 20 With UnEven Numbers.....");
            Thread.Sleep(500);
            UnEvenLoops(); //starts the even loop that counts to 20 with Uneven numbers only
        }
    }

    public static void HealthLoop()
    {
        //sets health at 100 at init
        int health = 100;
        while(health >= 0) //reduces health everytime run then displays current health
        {
            Console.WriteLine("Health: " + health);
            health -= 10;
            Thread.Sleep(500);
        }

        //if health is less than 0 display death message
        if (health < 0)
        {
            Console.WriteLine("You have died!");
        }
    }
     public static void UnEvenLoops() 
    {
        Console.WriteLine("Counting To 20 Now With UnEven Numbers Only.....");
        Thread.Sleep(1000);
        int i;
        for (i = 1; i <= 20; i++) //starts the counting
        {
            if(i % 1 == 0) //checks if they are Uneven
            Console.WriteLine("UNEVEN ITERATION" + " " + i); 
            Thread.Sleep(100); //slight pause so it doesnt spam to fast
        }

         if (i > 20)
        {
            Thread.Sleep(500);
            Console.WriteLine("Counting Finished");
        }
    }
}  