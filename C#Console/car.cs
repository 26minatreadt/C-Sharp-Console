public class car
{
    public string brand;
    public int speed;

    public void Drive()
    {
        Console.WriteLine("The car is driving.");
    }
}

// Creating an object (instance) of the class
car myCar = new Car();
myCar.brand = "Toyota";
myCar.speed = 60;
myCar.Drive(); // output: the car is driving