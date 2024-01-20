namespace Hausübung1
{
    internal class Seat
    {
        public bool IsDriverSeat { get; set; }
        public bool IsTaken => Person != null; // Nochmal erklären bitte

        public bool IsTaken2
        { get { return Person != null; } }

        public Person? Person { get; set; }  // Nochmal erklären bitte

        public override string ToString()
        {
            return $"{Person}";
        }
    }
}