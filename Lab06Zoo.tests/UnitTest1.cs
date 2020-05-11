using System;
using Xunit;

namespace Lab06Zoo.tests
{
    public class UnitTest1
    {
        [Fact]
        public void WhatSoundDoesSturgeonMake()
        {
            //arrange
            Animal steve = new LakeSturgeon();
            string expected = "I can make low-frequence 'sturgeon thunder'!";

            //act
            string result = steve.MakeSound();

            //Assert
            Assert.Equal(expected, result);

        }
        [Fact]
        public void Fish_Sturgeon_Can_Swim()
        {
            //arrange
            Fish bob = new LakeSturgeon();
            string expected = "Just keep swimming...";

            //act
            //Couldn't use bob.Swim, but had to use Fish.Swim()?
            string result = Fish.Swim();

            //Assert
            Assert.Equal(expected, result);

        }
      
    }
}
