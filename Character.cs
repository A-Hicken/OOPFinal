public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int BaseAttackPower { get; set; }

    public Character(string name, int health, int baseAttackPower)
    {
        Name = name;
        Health = health;
        BaseAttackPower = baseAttackPower;
    }

    public virtual int Attack()
    {
        return BaseAttackPower;
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
