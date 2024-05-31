namespace ArenaGame
{
    public class Mage : Hero
    {
        const int MagicShieldChance = 20;
        private const int ExtraSpellDamageChance = 15;

        public Mage() : this("Gandalf", new Sword(12))
        {

        }

        public Mage(string name, Weapon weapon) : base(name, weapon)
        {

        }

        public override void TakeDamage(int incomingDamage)
        {
            // Apply magic shield
            if (ThrowDice(MagicShieldChance))
            {
                int damageReduceCoef = Random.Shared.Next(30, 51);
                incomingDamage = incomingDamage - ((incomingDamage * damageReduceCoef) / 100);
            }
            // Default behavior
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int attack = base.Attack();
            // Apply extra spell damage
            if (ThrowDice(ExtraSpellDamageChance)) attack = attack + (attack / 2);
            return attack;
        }
    }
}
