namespace Lab06Zoo
{
    public abstract class Bird : Animal
    {
        
        public override string WhatKind => "Bird";

        public override int NumberOfLegs => 2;

        public Bird(string animalName) : base(animalName)
        {

        }
    }
}
