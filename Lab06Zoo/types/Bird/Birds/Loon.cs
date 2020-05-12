namespace Lab06Zoo
{
    public class Loon : Bird
    {
        public override bool CanThisAnimalFly => true;

        public override int Weight => 4;

        public override string Eat()
        {
            return "I eat mostly fish, with the occasional frog";
        }

        public override string MakeSound()
        {
            return "Not even going to try this one: https://www.cornell.edu/video/understanding-loons-6-vocalizations";
        }
    }
}
