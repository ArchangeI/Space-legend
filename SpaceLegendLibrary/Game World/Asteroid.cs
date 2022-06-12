using SpaceLegendLibrary.Resources;

namespace SpaceLegendLibrary.Game_World
{
    public class Asteroid : AstronomicalObject
    {
        public override string Name { get; set; }

        public override (int, int) Position { get; set; }

        public override Resource resource { get; set; }

        public Asteroid()
        {
            Name = Randomizer.RandomAsteriodName();

            resource = new()
            {
                Cryptocurrency = 0,
                Energy = 0,
                Ore = Randomizer.RandomOreNumber()
            };
        }
    }
}
