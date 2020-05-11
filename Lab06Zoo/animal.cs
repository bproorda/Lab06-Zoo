using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06Zoo
{
    public abstract partial class Animal
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

    }
}
