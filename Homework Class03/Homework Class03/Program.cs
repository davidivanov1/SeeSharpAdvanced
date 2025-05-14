// See https://aka.ms/new-console-template for more information
using Homework_Class03.Task01;
using Homework_Class03.Task02;


//class Program
//{
//    static void Main()
//    {
//        List<User> resultsById = UserDatabase.Search(id: 1);
//        List<User> resultsByName = UserDatabase.Search(name: "Alice");
//        List<User> resultsByAge = UserDatabase.Search(age: 30);
//        List<User> resultsByNameAndAge = UserDatabase.Search(name: "Alice", age: 22);

//        Console.WriteLine("Search by Id:");
//        resultsById.ForEach(Console.WriteLine);

//        Console.WriteLine("\nSearch by Name:");
//        resultsByName.ForEach(Console.WriteLine);

//        Console.WriteLine("\nSearch by Age:");
//        resultsByAge.ForEach(Console.WriteLine);

//        Console.WriteLine("\nSearch by Name and Age:");
//        resultsByNameAndAge.ForEach(Console.WriteLine);
//    }
//}

class Program
{
    static void Main()
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

