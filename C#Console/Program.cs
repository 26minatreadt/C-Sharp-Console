using MyCalculatorApp;

namespace C_console;

class Program
{

    static void Mycal()
    {
        Calculator calculator= new Calculator();
        Console.WriteLine("Add(int, int): " + calculator.Add(3,4));
        Console.WriteLine("Add(int, int, int): " + calculator.Add(3,4,12));
        Console.WriteLine("Add(double, double): " + calculator.Add(3.7, 5.9));
    }
    static void Main(string[] args)
    {
        //where we call our methods from seperate classes


        //Console.WriteLine("Hello, World!");
        //Var.MyVar();
        //Var.DataType();
        //SubStrings.MySubStrings();
        //Math.Numbers();
        //Input.Hello();
        //If.Number();
        //Math.Add(100,450);
        //Loops.ForLoops(); //Starts at For loops then Even loops then Uneven loops
        //Loops.EvenLoops(); //even loops then Uneven loops
        //Loops.UnEvenLoops(); //just uneven loop
        //Loops.HealthLoop();
        //Arrays.Array1(args);
        //Dictionary.Dict1(args);
        //Dictionary.Dict2(args);
    }
}
