namespace Lab06Zoo
{


    public abstract class Mammal : Animal
        {
            public override string WhatKind => "Mammal";

        public Mammal(string animalName) : base(animalName)
        {

        }
    }

}
