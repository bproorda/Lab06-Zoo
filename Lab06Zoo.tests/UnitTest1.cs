using System;
using Xunit;

namespace Lab06Zoo.tests
{
    public class UnitTest1
    {
        
        [Fact]
        public void WhatSoundDoesSturgeonMakeTest()
        {
            //arrange
            Animal steve = new LakeSturgeon("steve");
            string expected = "I can make low-frequence 'sturgeon thunder'!";

            //act
            string result = steve.MakeSound();

            //Assert
            Assert.Equal(expected, result);

        }
        [Fact]
        public void Fish_Sturgeon_Can_Swim_Test()
        {
            //arrange
            Fish bob = new LakeSturgeon("bob");
            string expected = "Just keep swimming...";

            //act
            string result = bob.Swim();
            

            //Assert
            Assert.Equal(expected, result);

        }
        [Fact]
        public void What_Does_Wolf_Do_Test()
        {
            //Arrange
            //Animal Jazz = new Wolf();
            Wolf Jazz = new Wolf("Jazz");
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

        [Fact]
        public void When_Does_Otter_Sleep_Test()
        {
            //arrange
            Animal Graeme = new RiverOtter("Graeme");
            string expected = "I sleep during the day in summer and night in the winter!";

            //act
            string result = Graeme.Sleep();

            //assert
            Assert.Equal(expected, result);
        }


        [Fact]
        public void What_Kind_Is_Loon()
        {
            //arrange 
            Animal Gena = new Loon("Gena");
            string expected = "Bird";

            //act
            string result = Gena.WhatKind;

            //assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void Can_Bats_Fly_Test()
        {
            //arrange
            Bat Grant = new Bat("Grant");

            //act
            bool actual = Grant.CanFly();

            //assert
            Assert.True(actual);
               
        }
        [Fact]
        public void Different_Animals_Different_Food_Test()
        {
            //arrange
            Animal Jerry = new Wolf("Jerry");
            Animal Bill = new LakeSturgeon("Bill");

            //act
            string wolfEats = Jerry.Eat();
            string sturgeonEats = Bill.Eat();

            //Assert
            Assert.NotEqual(wolfEats, sturgeonEats);
        }

        [Fact]
        public void Owl_Is_An_Owl_Test()
        {
            //arrange 
            Animal phil = new GreatHornedOwl("phil");
            

            //act
            var philType = phil.GetType();
            bool actual = philType.IsInstanceOfType(phil);

            //asssert
            Assert.True(actual);
        }
        [Fact]
        public void Owl_Is_An_Animal_Test()
        {
            //arrange 
            Animal phil = new GreatHornedOwl("phil");
       

            //asssert
            Assert.True(phil is Animal);
        }
    }
}
