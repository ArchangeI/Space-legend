using SpaceLegendLibrary.Game_World;

namespace SpaceLegendLibrary
{
    public class Map
    {
        private static Map instance;

        public (int, int) OrbitalStationPos = (20, 20);

        public Planet firstPlanet;
        public Planet secondPlanet;
        public Asteroid asteroid;

        private Map()
        {
            firstPlanet = new()
            {
                Position = (Randomizer.RandomPositionX(WhichAstranomicalObject.FirstPlanet), Randomizer.RandomPositionY())
            };
            secondPlanet = new()
            {
                Position = (Randomizer.RandomPositionX(WhichAstranomicalObject.SecondPlanet), Randomizer.RandomPositionY())
            };
        }

        public static Map GetMap()
        {
            if (instance == null)
            {
                instance = new();
            }
            return instance;
        }

        //If user have 3 victory generate asteroid
        public void CreateAsteroid()
        {
            asteroid = new()
            {
                Position = (Randomizer.RandomPositionX(WhichAstranomicalObject.Asteroid), Randomizer.RandomPositionY())
            };
            if (CheckPosition(asteroid))
            {
                asteroid.Position = (Randomizer.RandomPositionX(WhichAstranomicalObject.Asteroid), Randomizer.RandomPositionY());
            }
        }

        //Maybe refactoring
        private bool CheckPosition(Asteroid asteroid) => IsPositionEquals(firstPlanet.Position.Item1, asteroid.Position.Item1, firstPlanet.Position.Item2, asteroid.Position.Item2)
                || IsPositionEquals(secondPlanet.Position.Item1, asteroid.Position.Item1, secondPlanet.Position.Item2, asteroid.Position.Item2)
                || IsPositionEquals(OrbitalStationPos.Item1, asteroid.Position.Item1, OrbitalStationPos.Item2, asteroid.Position.Item2);

        private bool IsPositionEquals(int firstPosition, int secondPosition, int thirdPosition, int fourthPosition)
            => firstPosition == secondPosition && thirdPosition == fourthPosition;
    }
}
