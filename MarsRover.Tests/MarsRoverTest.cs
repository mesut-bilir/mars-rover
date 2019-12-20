using System;
using MarsRover.Application.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Tests
{
    [TestClass]
    public class MarsRoverTest
    {
        [TestMethod]
        public void FirstRoverCheckOutput()
        {
            Plateau plateauOne = new Plateau(new Position(5, 5));
            Rover firstRover = new Rover(plateauOne, new Position(1, 2), Directions.N);
            firstRover.Process("LMLMLMLMM");
            Assert.AreEqual(firstRover.ToString(), "1 3 N");
        }

        [TestMethod]
        public void SecondRoverCheckOutput()
        {
            Plateau plateauTwo = new Plateau(new Position(5, 5));
            Rover secondRover = new Rover(plateauTwo, new Position(3, 3), Directions.E);
            secondRover.Process("MMRMMRMRRM");
            Assert.AreEqual(secondRover.ToString(), "5 1 E");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IncorrectInput()
        {
            Plateau plateauOne = new Plateau(new Position(5, 5));
            Rover firstRover = new Rover(plateauOne, new Position(1, 2), Directions.N);
            firstRover.Process("LMAMMM");
        }
    }
}
