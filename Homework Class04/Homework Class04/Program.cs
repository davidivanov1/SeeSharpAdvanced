// See https://aka.ms/new-console-template for more information
using Homework_Class04;
using Homework_Class04.Task02;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        PrintInConsole printer = new PrintInConsole();

        printer.Print("Hello World!");
        printer.Print(123);
        printer.Print(3.14);

        Console.WriteLine();

        List<string> stringList = new List<string> { "One", "Two", "Three" };
        int[] intArray = { 1, 2, 3, 4, 5 };

        printer.PrintCollection(stringList);
        printer.PrintCollection(intArray);

    }
}

class Program1
{
    static void Main(string[] args)
    {
        Vehicle car = new Car();
        Vehicle motorBike = new MotorBike();
        Vehicle boat = new Boat();
        Vehicle plane = new Airplane();
        car.DisplayInfo();
        motorBike.DisplayInfo();
        boat.DisplayInfo();
        plane.DisplayInfo();
    }
}
