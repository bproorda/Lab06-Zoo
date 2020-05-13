namespace Lab06Zoo
{
    public class GreatHornedOwl : Bird, ICanFLyLikeAnEagle, Hobby
    {
       

        public override int Weight => 3;

        public string MyHobby => "listening to The WHO";

        public bool CanFly()
        {
            return true;
        }

        public override string Eat()
        {
            return "I eat rodents, hares, and squirrels";
        }

        public string GetMyHobby()
        {
            return MyHobby;
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
