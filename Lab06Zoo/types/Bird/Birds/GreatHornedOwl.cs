namespace Lab06Zoo
{
    public class GreatHornedOwl : Bird, ICanFLyLikeAnEagle
    {
       

        public override int Weight => 3;

        public bool CanFly()
        {
            return true;
        }

        public override string Eat()
        {
            return "I eat rodents, hares, and squirrels";
        }

        public override string MakeSound()
        {
            return "hoo-h'HOO-hoo-hoo";
        }
        public override string Sleep()
        {
            return "I sleep mostly during the day";
        }
    }
}
