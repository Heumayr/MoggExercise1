using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hausübung1
{
    internal class Car
    {
        public static int CountCreatedCars = 0;

        private string model = string.Empty;
        private string color = string.Empty;
        private int build_year;
        private int max_speed;
        private int speed;
        private int accelerate;

        public string Model
        { get { return model; } set { model = value; } }

        public string Color
        { get { return color; } set { color = value; } }

        public int Build_Year
        { get { return build_year; } set { build_year = value; } }

        public int Alter
        { get { return DateTime.Now.Year - build_year; } }

        public int Max_Speed
        { get { return max_speed; } set { max_speed = value; } }

        public int Speed
        { get { return speed; } set { speed = value; } }

        public int Accelerate
        { get { return accelerate; } set { accelerate = value; } }

        public Car(string model, string color, int build_year, int max_Speed)
        {
            Model = model;
            Color = color;
            Build_Year = build_year;
            Max_Speed = max_Speed;

            Init();
        }

        public Car()
        {
            Init();
        }

        private void Init()
        {
            GenerateSeats(5);
            GenerateDoors(4);
            CountCreatedCars++;
        }

        public List<Seat> Seats { get; set; } = new();

        private void GenerateSeats(int amountSeats)
        {
            for (int i = 0; i < amountSeats; i++)
            {
                var tempSeat = new Seat();
                if (i == 0)
                {
                    tempSeat.IsDriverSeat = true;
                }
                Seats.Add(tempSeat);
            }
        }

        public List<Door> Doors { get; set; } = new();

        private void GenerateDoors(int amountDoors)
        {
            for (int i = 0; i < amountDoors; i++)
            {
                var tempDoor = new Door();

                switch (i)
                {
                    case 0:
                        tempDoor.Position = "Fahrertür";
                        Doors.Add(tempDoor);
                        break;

                    case 1:
                        tempDoor.Position = "Beifahrertür";
                        Doors.Add(tempDoor);
                        break;

                    case 2:
                        tempDoor.Position = "Tür Fahrerseite hinten";
                        Doors.Add(tempDoor);
                        break;

                    case 3:
                        tempDoor.Position = "Tür Beifahrerseite hinten";
                        Doors.Add(tempDoor);
                        break;

                    default: break;
                }
            }
        }

        public void Throttle(int accelerate)
        {
            Speed = Speed + accelerate;
        }

        public static void Throttle2(Car car, int accelerate)
        {
            car.Speed = car.Speed + accelerate;
        }

        public override string ToString()
        {
            return $"{Model}, {Build_Year}, {Alter}, {Seats.Count} Sitzer ";
        }
    }
}