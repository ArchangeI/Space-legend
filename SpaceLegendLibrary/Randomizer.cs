using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceLegendLibrary
{
    public enum WhichAstranomicalObject
    {
        FirstPlanet = 1,
        SecondPlanet = 2,
        Asteroid = 3
    }

    public static class Randomizer
    {
        private const string CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private const int ASTEROID_NAME_LENGTH = 8;
        private const int MIN_POSITION = 0;
        private const int MIDDLE_POSITION = 20;
        private const int MAX_POSITION = 41;

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

        public static int RandomPositionX(WhichAstranomicalObject whichObject)
        {
            switch (whichObject)
            {
                case WhichAstranomicalObject.FirstPlanet:
                    return _random.Next(MIN_POSITION, MIDDLE_POSITION);
                case WhichAstranomicalObject.SecondPlanet:
                    return _random.Next(MIDDLE_POSITION, MAX_POSITION);
                case WhichAstranomicalObject.Asteroid:
                    return _random.Next(MIN_POSITION, MAX_POSITION);
                default:
                    return 0;
            }
        }

        public static int RandomPositionY() => _random.Next(MIN_POSITION, MAX_POSITION);
    }
}
