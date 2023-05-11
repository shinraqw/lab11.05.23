using System.Collections;

namespace lab11._05._23
{
    internal class Program
    {
        class Program1
        {
            static void Main(string[] args)
            {
                Alphabet alphabet = new Alphabet();//1

                foreach (char letter in alphabet)
                {
                    Console.Write(letter + " ");
                }

                Console.WriteLine("----");
                Apartment[] apartments = new Apartment[]//2
                    {
                        new Apartment(new string[] { "John", "Mary" }),
                        new Apartment(new string[] { "Bob", "Alice", "Charlie" }),
                        new Apartment(new string[] { "David", "Emily" })
                    };

                House house = new House(apartments);

                foreach (Apartment apartment in house)
                {
                    Console.Write("Apartment residents: ");
                    foreach (string resident in apartment)
                    {
                        Console.Write(resident + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("----");
                Car[] cars = new Car[]//3
                    {
                     new Car("Ford", "Mustang"),
                     new Car("Chevrolet", "Camaro"),
                     new Car("Dodge", "Charger")
                    };

                Garage garage = new Garage(cars);

                foreach (Car car in garage)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}