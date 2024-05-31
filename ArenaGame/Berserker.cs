namespace ArenaGame
{
    public class Berserker : Hero
    {
        const int RageDamageReductionChance = 25;
        private const int DoubleDamageChance = 10;

        public Berserker() : this("Conan", new Axe(15, false))
        {

        }

        public Berserker(string name, Weapon weapon) : base(name, weapon)
        {

        }

        public override void TakeDamage(int incomingDamage)
        {
            // Apply rage damage reduction
            if (ThrowDice(RageDamageReductionChance))
            {
                int damageReduceCoef = Random.Shared.Next(25, 41);
                incomingDamage = incomingDamage - ((incomingDamage * damageReduceCoef) / 100);
            }
            // Default behavior
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int attack = base.Attack();
            // Apply double damage when enraged
            if (ThrowDice(DoubleDamageChance)) attack = attack * 2;
            return attack;
        }
    }
}
