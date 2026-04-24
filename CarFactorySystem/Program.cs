using CarFactorySystem.Factory;
using CarFactorySystem.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("__________Welcome To Car Factory System__________");
        
        Console.WriteLine("...........................................");
        Console.WriteLine("Generating A Car With Gas Engine...!");
        Console.WriteLine("...........................................");

        var car1 = CarFactory.GenerateCar("Gas");
        car1.Start();
        car1.Accelerate();
        car1.Accelerate();
        car1.Brake();
        car1.Stop();


        Console.WriteLine("...........................................");
        Console.WriteLine("Changing The Engine To Electric Engine...!");
        Console.WriteLine("...........................................");

        car1.ChangeEngine(new ElectricEngine());

        car1.Start();
        car1.Accelerate();
        car1.Brake();
        car1.Stop();

        Console.WriteLine("...........................................");
        Console.WriteLine("Generating Another Car With Hybrid Engine...!");
        Console.WriteLine("...........................................");

        var car2 = CarFactory.GenerateCar("hybrid");
        car2.Start();
        car2.Accelerate();
        car2.Accelerate();
        car2.Accelerate();
        car2.Accelerate();
        car2.Brake();
        car2.Stop();
        Console.WriteLine("...........................................");

    }
}