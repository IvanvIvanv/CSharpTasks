namespace VinogradovIE_CatFramework
{
    public class CuteCat : Cat
    {
        public override int Fluffiness { get; }

        public CuteCat(int fluffiness = 50)
        {
            Fluffiness = fluffiness;

            if (FluffinessRangeCheck(fluffiness)) throw new CatException("Unable to create a cute cat with fluffiness: " + fluffiness);
        }

        public override string FluffinessCheck()
        {
            return Fluffiness switch
            {
                < 1 => "Sphynx",
                < 21 => "Slightly",
                < 51 => "Medium",
                < 75 => "Heavy",
                _ => "OwO",
            };
        }

        public override string ToString()
        {
            return "A cute cat with fluffiness: " + Fluffiness;
        }

        private static bool FluffinessRangeCheck(int fluffiness)
        {
            return fluffiness < 0 || fluffiness > 140;
        }
    }
}
