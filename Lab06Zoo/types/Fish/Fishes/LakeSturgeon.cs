using System;

namespace Lab06Zoo
{
    public class LakeSturgeon : Fish
    {
        public override int Weight => 300;

        public override string Eat()
        {
            return "I eat worms, larvae, and leeches";
        }

        public override string MakeSound()
        {
            return "I can make low-frequence 'sturgeon thunder'!";
        }

        public override string Sleep()
        {
            return "I never sleep!";
        }

        public LakeSturgeon(string animalName) : base(animalName)
            {

                }
    }


}
