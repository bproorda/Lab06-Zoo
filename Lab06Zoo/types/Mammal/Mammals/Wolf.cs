﻿namespace Lab06Zoo
{
    public class Wolf : Mammal
    {
        public override int Weight => 180;
        public override int NumberOfLegs => 4;

        public override string Eat()
        {
            return "I love to chase down deer with my pack and  eat 'em!";
        }

        public override string MakeSound()
        {
            return "Woof!";
        }
        public  string Howl()
        {
            return "ooowOOOOOOO!";
        }

        public override string Sleep()
        {
            return "I sleep during the day and hunt at night.";
        }
    }
}
