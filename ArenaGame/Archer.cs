namespace ArenaGame
{
    public class Archer : Hero
    {
        const int DodgeChance = 15;
        private const int CriticalHitChance = 10;

        public Archer() : this("Robin Hood", new Bow(8))
        {

        }

        public Archer(string name, Weapon weapon) : base(name, weapon)
        {

        }

        public override void TakeDamage(int incomingDamage)
        {
            // Apply special skill: dodge
            if (ThrowDice(DodgeChance)) incomingDamage = 0;
            // Default behavior
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int attack = base.Attack();
            // Apply special skill: critical hit
            if (ThrowDice(CriticalHitChance)) attack = attack * 2;
            return attack;
        }
    }
}
