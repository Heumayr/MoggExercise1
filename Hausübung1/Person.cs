using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Hausübung1
{
    internal class Person
    {
        private string firstname = string.Empty;
        private string lastname = string.Empty;
        private int age = 0;
        private int birthyaer;
        private bool is_adult;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public int Age
        { get { return DateTime.Now.Year - Birthyear; } }

        public bool IsAdult
        {
            get
            {
                if (Age >= 18)
                {
                    return is_adult = true;
                }
                else
                {
                    return is_adult = false;
                }
            }
        }

        public int Birthyear
        { get { return birthyaer; } set { birthyaer = value; } }

        public Car? Car { get; set; }
        public Seat? Seat { get; set; }

        public bool IsSeated => Seat != null;

        public Person(string firstname, string lastname, int birthyaer)
        {
            Firstname = firstname;
            Lastname = lastname;
            Birthyear = birthyaer;
        }

        public Person()
        { }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} {Age}";
        }

        public void EnterCar(Car car, int seat)
        {
            if (IsSeated)
            {
                Console.WriteLine("Person sitzt bereits");
                return;
            }

            if (seat < 0 || car.Seats.Count() - 1 < seat)
            {
                Console.WriteLine($"Sitz nicht vorhanden! Sitz: {seat}");
                return;
            }

            if (car.Seats[seat].IsTaken)
            {
                Console.WriteLine("Der Sitz ist besetzt!");
                return;
            }

            Car = car;
            Seat = Car.Seats[seat];
            Seat.Person = this;
            Console.WriteLine($"{Firstname} hat Platz genommen!");
        }

        public void LeaveCar()
        {
            if (!IsSeated)
            {
                Console.WriteLine("Ich sitze nicht in einem Auto!!!");
                return;
            }

            Seat!.Person = null;
            Seat = null;
            Car = null;
        }
    }
}