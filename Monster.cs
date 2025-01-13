public class Monster : Character
{
    public Monster(string name, int health, int baseAttackPower)
        : base(name, health, baseAttackPower)
    {
    }

    public static Monster GenerateRandomMonster()
    {
        Random rand = new Random();
        int monsterType = rand.Next(1, 4); // 3 types of monsters

        switch (monsterType)
        {
            case 1:
                return new Monster("Goblin", 50, 5);
            case 2:
                return new Monster("Dragon", 150, 20);
            case 3:
                return new Monster("Troll", 100, 10);
            default:
                return new Monster("Unknown", 50, 5);
        }
    }
}
