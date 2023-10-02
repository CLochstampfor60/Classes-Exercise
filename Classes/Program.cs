using System.ComponentModel.DataAnnotations;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Name = "Tacoma";
            myCar.Year = 2018;

            Console.WriteLine($"My current vehcile for transportation is the {myCar.Year} {myCar.Make} {myCar.Name}.");
        }
    }
}
