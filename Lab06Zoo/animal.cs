using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06Zoo
{
    public abstract class Animal
    {
        //properties
        public abstract string WhatKind { get; }
        public abstract int Weight { get; }

        public virtual int NumberOfLegs { get; }


        //Methods

        public abstract string  Eat();

        public abstract string  MakeSound();

        public virtual string Sleep()
        {
            return "ZZZZZZZ";
        }

        //Base constructor
        //Does this have to be a field?
        public string Name;

        public Animal(string animalName)
        {
            Name = animalName;
        }


    }
        

}
