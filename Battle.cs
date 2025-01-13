public class Battle
{
    public static void StartBattle(Player player, Monster monster)
    {
        Random rand = new Random();
        bool isPlayerTurn = true;

        while (player.IsAlive() && monster.IsAlive())
        {
            if (isPlayerTurn)
            {
                Console.WriteLine($"{player.Name}'s turn!");
                Console.WriteLine("1. Attack\n2. Heal\n3. Run");
                string choice = Console.ReadLine();

                if (choice == "1") // Attack
                {
                    int damage = player.Attack();
                    monster.Health -= damage;
                    Console.WriteLine($"{player.Name} attacks {monster.Name} for {damage} damage.");
                }
                else if (choice == "2") // Heal
                {
                    int healed = player.Heal();
                    Console.WriteLine($"{player.Name} heals for {healed} health.");
                }
                else if (choice == "3") // Run
                {
                    Console.WriteLine($"{player.Name} decides to run away!");
                    break;
                }
            }
            else
            {
                int damage = monster.Attack();
                player.Health -= damage;
                Console.WriteLine($"{monster.Name} attacks {player.Name} for {damage} damage.");
            }

            isPlayerTurn = !isPlayerTurn; // Switch turn
        }

        if (player.IsAlive())
        {
            Console.WriteLine($"{player.Name} has defeated {monster.Name}!");
        }
        else
        {
            Console.WriteLine($"{player.Name} has been defeated!");
        }
    }
}
