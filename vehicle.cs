public class Vehicle
{
    public string brand;

    public void Start()
    {
        Console.WriteLine("Vehicle is starting.");
    }
}
//child class inherits from vehicle
public class Car : Vehicle
{
    public int speed;

    public void Drive()
    {
        Console.WriteLine(brand + "is driving at " + speed + " km/h. ");
    }
}

Car myCar = new Car();
myCar.brand = "Toyata";
myCar.speed = 120;
myCar.Start(); //inherited method
myCar.Drive(); // output: Toyata is driving at 120 km/h.