using Hausübung1.Data;

namespace Hausübung1
{
    internal class Program
    {
        private static Person[] persons = [];
        private static Car[] cars = [];

        private static readonly string FilepathPersons = @"Data\Persons.csv";

        private static readonly string FilePathCars = "Data\\Cars.csv";

        private static void Main(string[] args)
        {
            persons = Loader.LoadPeople(FilepathPersons);

            //foreach (Person person in persons)
            //{
            //    Console.WriteLine(person);
            //}

            cars = Loader.LoadCars(FilePathCars);

            //foreach (Car car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            var results = persons.Where(p => p.IsAdult).OrderBy(p => p.Firstname);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        public static void OldCode()
        {
            Console.WriteLine(Car.CountCreatedCars);

            Console.WriteLine("Wieviele Personen möchten Sie anlegen:");

            int anzPers = Convert.ToInt32(Console.ReadLine());
            var person_List = new List<Person>();

            for (int i = 0; i < anzPers; i++)
            {
                person_List.Add(Person_data_input2());
            }

            persons = person_List.ToArray();

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("Wieviele Fahrzeuge möchten Sie anlegen:");

            int anzCar = Convert.ToInt32(Console.ReadLine());
            var car_List = new List<Car>();

            for (int i = 0; i < anzCar; i++)
            {
                car_List.Add(Car_data_input());
            }

            cars = car_List.ToArray();

            if (persons.Length >= 1 && cars.Length >= 1)
            {
                persons[0].EnterCar(cars[0], 0);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);

                var count = 1;

                foreach (var seat in car.Seats)
                {
                    Console.Write($"\tSitz {count++}: ");
                    Console.WriteLine(seat);
                }
            }

            //Accelerate();

            Console.WriteLine(Car.CountCreatedCars);

            var car1 = new Car();

            car1.Throttle(5); // Instanz Methode
            Car.Throttle2(car1, 5); //Klassen Methode
        }

        public static Person Person_data_input2()
        {
            var person = new Person();
            Console.WriteLine("Vornamen eingeben");
            person.Firstname = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Nachnamen eingeben");
            person.Lastname = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Geburtsjahr eingeben");
            person.Birthyear = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            return person;
        }

        public static Car Car_data_input()
        {
            var car = new Car();
            Console.Clear();
            Console.WriteLine("Bitte Model eingeben");
            car.Model = Console.ReadLine();
            Console.WriteLine("Bitte Farbe eingeben");
            car.Color = Console.ReadLine();
            Console.WriteLine("Bitte Baujahr eingeben");
            car.Build_Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte max Geschwindigkeit eingeben");
            car.Max_Speed = Convert.ToInt32(Console.ReadLine());
            return car;
        }

        //public static void Accelerate()
        //{
        //    Console.WriteLine($"Ihre Geschwindigkeit ist {car1.Speed}");
        //    Console.WriteLine($"Um wieviel KMH wollen Sie beschleunigen?");
        //    car1.Throtle(Convert.ToInt32(Console.ReadLine()));
        //    //Car1.Speed = Car1.Speed+(Convert.ToInt32(Console.ReadLine()));
        //    Console.WriteLine($"Ihre Geschwindigkeit ist {car1.Speed}");
        //}

        //public static void Car2_Print()
        //{
        //    Car2.Model = temp_Model;
        //    Car2.Color = temp_Color;
        //    Car2.Build_Year = temp_Year;
        //    Console.WriteLine(Car2.Model);
        //    Console.WriteLine(Car2.Color);
        //    Console.WriteLine(Car2.Build_Year);
        //}
        //public static void Person_data_input(Person person)
        //{
        //    Console.WriteLine("Vornamen eingeben");
        //    person.Firstname = Console.ReadLine();
        //    Console.WriteLine("Nachnamen eingeben");
        //    person.Lastname = Console.ReadLine();
        //    Console.WriteLine("Geburtsjahr eingeben");
        //    person.Birthyear = Convert.ToInt32(Console.ReadLine());
        //    Console.Clear();
        //}
    }
}