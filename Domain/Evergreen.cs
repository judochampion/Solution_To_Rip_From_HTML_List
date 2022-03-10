namespace Domain
{
    public class Evergreen
    {
        public int Number { get; set; }

        public string Artist { get; set; }

        public string Song { get; set; }

        public override string ToString()
        {
            return $"{Number};{Artist};{Song}";
        }
    }
}