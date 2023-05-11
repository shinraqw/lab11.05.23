using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11._05._23
{
    public class Alphabet : IEnumerable
    {
        private char[] letters;

        public Alphabet()
        {
            letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < letters.Length; i++)
            {
                yield return letters[i];
            }
        }
    }
    public class House : IEnumerable
    {
        private Apartment[] apartments;

        public House(Apartment[] apartments)
        {
            this.apartments = apartments;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < apartments.Length; i++)
            {
                yield return apartments[i];
            }
        }
    }
    public class Apartment : IEnumerable
    {
        private string[] residents;

        public Apartment(string[] residents)
        {
            this.residents = residents;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < residents.Length; i++)
            {
                yield return residents[i];
            }
        }
    }
    public class Garage : IEnumerable
    {
        private Car[] cars;

        public Garage(Car[] cars)
        {
            this.cars = cars;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                yield return cars[i];
            }
        }
    }

    public class Car
    {
        private string make;
        private string model;

        public Car(string make, string model)
        {
            this.make = make;
            this.model = model;
        }

        public override string ToString()
        {
            return make + " " + model;
        }
    }
}
