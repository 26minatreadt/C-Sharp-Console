public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal Sound");
    }
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