public class Player : Character
{
    public Weapon EquippedWeapon { get; set; }

    public Player(string name) : base(name, 100, 10)
    {
        // Default values for player, can be changed later
        EquippedWeapon = Weapon.GenerateRandomWeapon();
    }

    public int Heal()
    {
        int healAmount = 20;
        Health += healAmount;
        return healAmount;
    }

    public int CheckForCrit()
    {
        Random rand = new Random();
        return rand.Next(0, 100) < 20 ? 2 : 1; // 20% chance of crit
    }

    public override int Attack()
    {
        int baseDamage = base.Attack();
        int critMultiplier = CheckForCrit();
        return baseDamage * critMultiplier + EquippedWeapon.AttackBonus;
    }
}

