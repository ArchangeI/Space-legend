namespace SpaceLegendLibrary.Game_World
{
    public class Planet : AstronomicalObject
    {
        private const int ORE_LIMIT = int.MaxValue;

        public override string Name { get; set; }

        public override (int, int) Position { get; set; }

        public override Resource resource { get; set; }
        
        public Planet()
        {
            Name = Randomizer.RandomPlanetName();

            resource = new()
            {
                Cryptocurrency = 0,
                Energy = 0,
                Ore = ORE_LIMIT
            };
        }
    }
}
