namespace Extension
{
    public sealed class Road
    {
        public string Number { get; set; }
        public int Lenght { get; set; }

        public override string ToString()
        {
            return $"Road: {Number}. + \n + Lenght: {Lenght}";
        }
    }
}