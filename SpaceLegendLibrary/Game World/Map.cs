using SpaceLegendLibrary.Game_World;

namespace SpaceLegendLibrary
{
    //Only one map can be(singltone or static)
    public class Map
    {
        public (int, int) OrbitalStationPos = (20, 20);

        public Planet firstPlanet;
        public Planet secondPlanet;

        public Map()
        {
            firstPlanet = new();
            secondPlanet = new();
        }
    }
}
