using System;
using Xunit;
using SpaceLegendLibrary.Game_World;
using SpaceLegendLibrary;

namespace SpaceLegendTests
{
    public class GameWorldTests
    {
        [Fact]
        public void FirstPlanetPositionOnLeftSide()
        {
            Map map = new();

            int minExpectedXPosition = 0;
            int maxExpectedXPosition = 19;
            int actualXPosition = map.firstPlanet.Position.Item1;

            Assert.InRange(actualXPosition, minExpectedXPosition, maxExpectedXPosition);

            int minExpectedYPosition = 0;
            int maxExpectedYPosition = 40;
            int actualYPosition = map.firstPlanet.Position.Item2;
            
            Assert.InRange(actualYPosition, minExpectedYPosition, maxExpectedYPosition);
        }

        [Fact]
        public void Test1()
        {
            Map map = new();
            map.CreateAsteroid();
        }
    }
}
