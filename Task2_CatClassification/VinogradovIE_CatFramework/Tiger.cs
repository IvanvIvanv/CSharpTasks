namespace VinogradovIE_CatFramework
{
    public class Tiger : Cat
    {
        public override int Fluffiness { get; }

        public double Weight { get; }

        public Tiger(double weight, int fluffiness = 50)
        {
            bool weightOutOfRange = WeightRangeCheck(weight);
            bool fluffinessOutOfRange = FluffinessRangeCheck(fluffiness);

            if (weightOutOfRange && fluffinessOutOfRange)
            {
                throw new CatException("Unable to create a tiger with weight: " + weight + " and fluffiness: " + fluffiness);
            }
            else if (weightOutOfRange)
            {
                 throw new CatException("Unable to create a tiger with weight: " + weight);
            }
            else if (fluffinessOutOfRange)
            {
                throw new CatException("Unable to create a tiger with fluffiness: " + fluffiness);
            }

            Weight = weight;
            Fluffiness = fluffiness;
        }

        public override string FluffinessCheck()
        {
            return "Kycb!";
        }

        public override string ToString()
        {
            return "A cat with weight: " + Weight + " and fluffiness: " + Fluffiness;
        }

        private static bool WeightRangeCheck(double weight)
        {
            return weight < 75 || weight > 140;
        }

        private static bool FluffinessRangeCheck(int fluffiness)
        {
            return fluffiness < 0 || fluffiness > 100;
        }
    }
}
