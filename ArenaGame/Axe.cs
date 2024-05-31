namespace ArenaGame
{
    public class Axe : Weapon
    {
        public bool isDoubleSidedAxe { get; private set; }
        public Axe(int damage, bool isDoubleSidedAxe) : base("Axe", damage, 11)
        {
            this.isDoubleSidedAxe = isDoubleSidedAxe;
        }

        public override int Use()
        {
            if (isDoubleSidedAxe)
                return base.Use() + (this.Damage / 2 <= 0 ? 1 : this.Damage / 2);
            return base.Use();
        }
    }
}
