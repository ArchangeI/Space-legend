
using SpaceLegendLibrary.Resources;

namespace SpaceLegendLibrary.Game_World
{
    public abstract class AstronomicalObject
    {
        public abstract string Name { get; set; }

        public abstract (int, int) Position { get; set; }

        public abstract Resource resource { get; set; }
    }
}
