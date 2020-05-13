namespace Lab06Zoo
{
    public class Loon : Bird, ICanFLyLikeAnEagle
    {
        

        public override int Weight => 4;

        public bool CanFly()
        {
            return true;
        }

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
