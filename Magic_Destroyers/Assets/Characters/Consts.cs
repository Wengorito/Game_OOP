
namespace Assets.Characters
{
    public static class Consts
    {
        public const int ABILITYPOINTS = 100;

        internal const int MIN_AGE = 18;
        internal const int LEVEL = 1;

        public static class Melee
        {
            public const int HEALTHPOINTS = 200;
            public const int MAX_AGE = 60;
        }


        public static class Warrior
        {
            public const string NAME = "Barb";
            public const int MAX_AGE = 30;
        }

        public static class Spellcaster
        {
            public const int HEALTHPOINTS = 100;
            public static int MIN_AGE = 30;
        }

        public static class Mage
        {
            public const string NAME = "Sorc";
            public const int MAX_AGE = 100;
            public const int MIN_AGE = 40;
        }
    }
}
