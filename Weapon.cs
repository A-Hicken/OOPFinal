public class Weapon
{
    public string Name { get; set; }
    public int AttackBonus { get; set; }

    public Weapon(string name, int attackBonus)
    {
        Name = name;
        AttackBonus = attackBonus;
    }

    public static Weapon GenerateRandomWeapon()
    {
        Random rand = new Random();
        int weaponType = rand.Next(1, 4); // 3 weapon types

        switch (weaponType)
        {
            case 1:
                return new Weapon("Sword", 10);
            case 2:
                return new Weapon("Axe", 15);
            case 3:
                return new Weapon("Bow", 8);
            default:
                return new Weapon("Dagger", 5);
        }
    }
}
