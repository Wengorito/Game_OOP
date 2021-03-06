namespace Assets.Equipment.Armors.Light
{
    class ClothRobe : Light
    {
        private const int DEFAULT_ARMOR_POINTS = 10;

        public ClothRobe()
            : this(DEFAULT_ARMOR_POINTS)
        {
        }

        public ClothRobe(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
