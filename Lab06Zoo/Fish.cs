using System;

namespace Lab06Zoo
{
    public abstract class Fish : Animal
    {
        public override string WhatKind => "Fish";

        //concrete
        public string Swim()
        {
            return "Just keep swimming...";
        }
    }
}
