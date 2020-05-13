namespace Lab06Zoo
{
    public class RiverOtter : Mammal
    {
        public override int Weight => 18;

        public override int NumberOfLegs => 4;

        public override string Eat()
        {
            return "I love to fish!";
        }

        public override string MakeSound()
        {
            return "I make lots of squeaking sounds!";
        }

        public override string Sleep()
        {
            return "I sleep during the day in summer and night in the winter!";
        }

        public string Play()
        {
            return "Do you know Go Fish?";
        }
        public RiverOtter(string animalName) : base(animalName)
        {

        }
    }

}
