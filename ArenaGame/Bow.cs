namespace ArenaGame
{
    public class Bow : Weapon
    {
        public int Arrows { get; private set; }
        public Bow(int damage) : base("Bow", damage, 5)
        {
            Arrows = 15;
        }

        public override int Use()
        {
            if (Arrows > 0)
                return base.Use();
            else
                Console.WriteLine("No arrows left");
            return 0;
        }
    }
}
