using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hausübung1.Data
{
    internal static class Loader
    {
        internal static Person[] LoadPeople(string filepath)
        {
            var result = new List<Person>();

            string text = File.ReadAllText(filepath);

            string[] lines = text.Split('\n');

            for (int i = 1; i < lines.Length; i++)
            {
                //0 Firstname;1 Lastname;2 YearOfBirth
                string[] dataset = lines[i].Split(';');

                Person tempPerson = new Person()
                {
                    Firstname = dataset[0],
                    Lastname = dataset[1],
                    Birthyear = Convert.ToInt32(dataset[2]),
                };

                result.Add(tempPerson);
            }

            return result.ToArray();
        }

        internal static Car[] LoadCars(string filepath)
        {
            return File.ReadAllLines(filepath)
                       .Skip(1)
                       .Select(l => l.Split(';'))
                       .Select(d =>
                       {
                           return new Car()
                           {
                               Model = d[0],
                               Color = d[1],
                               Build_Year = Convert.ToInt32(d[2]),
                               Max_Speed = Convert.ToInt32(d[3]),
                           };
                       }).ToArray();
        }

        //E:\Programmieren_lernen_Richi\Richi_HÜ\Hausübung1\Hausübung1\Data\Persons.csv
        //E:\Programmieren_lernen_Richi\Richi_HÜ\Hausübung1\Hausübung1\bin\Release\net8.0\Data
    }
}