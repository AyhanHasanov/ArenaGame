namespace ArenaGame
{
    public abstract class Weapon
    {
        public string Name { get; private set; }
        public int Damage { get; private set; }
        public int DamageIncreaseChance { get; private set; }

        protected Weapon(string name, int damage, int damageIncreaseChance)
        {
            Name = name;
            Damage = damage;
            DamageIncreaseChance = damageIncreaseChance;
        }

        public virtual int Use()
        {
            //Returns the damage
            return CalculateDamageIncreaseChance() ? Damage + (Damage / 10 + Damage % 10) : Damage;
        }

        private bool CalculateDamageIncreaseChance()
        {
            Random random = new Random();
            int roll = random.Next(1, 101);
            return roll <= DamageIncreaseChance;
        }

        public override string ToString()
        {
            return $"[Weapon]: {Name} with {Damage} damage and chance of increased damage {DamageIncreaseChance}/100.";
        }
    }
}
