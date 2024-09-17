public abstract class Animal
{
    public abstract void MakeSound();
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

Animal = myDog = new Dog();
myDog.MakeSound(); // output: Bark (polymorphism in action)