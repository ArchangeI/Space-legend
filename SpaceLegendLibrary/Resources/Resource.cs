namespace SpaceLegendLibrary.Resources
{
    public class Resource
    {
        public Resource(decimal amountOfCrypto)
        {
            Crypto = new Cryptocurrency(amountOfCrypto);
        }

        public Cryptocurrency Crypto { get; set; }

        public int Cryptocurrency { get; set; }

        public float Energy { get; set; }

        public int Ore { get; set; }
    }
}
