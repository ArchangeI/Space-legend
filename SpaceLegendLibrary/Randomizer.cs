using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceLegendLibrary
{
    public static class Randomizer
    {
        private const string CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private const int ASTEROID_NAME_LENGTH = 8;

        private static List<string> _planetsName = new List<string>()
        {
            "Titan",
            "Calisto",
            "Phobos",
            "Deimos",
            "Moon",
            "Io",
            "Tarvos"
        };
        private static Random _random = new Random();

        public static string RandomPlanetName()
        {
            int minValue = 0;
            int maxValue = 7;

            var randomIndex = _random.Next(minValue, maxValue);

            return _planetsName[randomIndex];
        }

        public static string RandomAsteriodName() => new string(Enumerable.Repeat(CHARS, ASTEROID_NAME_LENGTH)
              .Select(s => s[_random.Next(s.Length)]).ToArray());

        public static int RandomOreNumber()
        {
            int minValue = 100;
            int maxValue = 1001;
            return _random.Next(minValue, maxValue);
        }
    }
}
