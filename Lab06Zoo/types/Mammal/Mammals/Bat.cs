namespace Lab06Zoo
{
    public class Bat : Mammal, ICanFLyLikeAnEagle, Hobby
    {
        public override int Weight => 1;
        public override int NumberOfLegs => 2;

        public string MyHobby => "Hanging out";

        public bool CanFly()
        {
            return true;
        }

        public override string Eat()
        {
            return "I love to eat bugs as I fly through the air!";
        }

        public string GetMyHobby()
        {
            return MyHobby;
        }

        public override string MakeSound()
        {
            return "I use my voice to see in the dark!";
        }

        public override string Sleep()
        {
            return "I like to hide in caves and other dark places during the day";
        }
        public Bat(string animalName) : base(animalName)
        {

        }
    }
    

}
