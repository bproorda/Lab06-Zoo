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
            string result = bob.Swim();
            

            //Assert
            Assert.Equal(expected, result);

        }
        [Fact]
        public void What_Does_Wolf_Do()
        {
            //Arrange
            //Animal Jazz = new Wolf();
            Wolf Jazz = new Wolf();
            string expected = "ooowOOOOOOO!";
            int expected2 = 4;
            

            //Act
            string result = Jazz.Howl();
            int wolfLegsNumber = Jazz.NumberOfLegs;
            //string result = Wolf.Howl();

            //Act
            Assert.Equal(expected, result);

            //Act
            Assert.Equal(expected2, wolfLegsNumber);
        }
    }
}
