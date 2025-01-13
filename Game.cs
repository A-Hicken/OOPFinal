public class Game
{
    private Player player;

    public void StartGame()
    {
        Console.WriteLine("Enter your character's name:");
        string playerName = Console.ReadLine();
        player = new Player(playerName);

        bool gameRunning = true;
        while (gameRunning)
        {
            ShowMainMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Fight Monsters
                    Monster monster = Monster.GenerateRandomMonster();
                    Console.WriteLine($"A wild {monster.Name} appears!");
                    Battle.StartBattle(player, monster);
                    break;

                case "2": // View Player Stats
                    Console.WriteLine($"Player: {player.Name}\nHealth: {player.Health}\nWeapon: {player.EquippedWeapon.Name}");
                    break;

                case "3": // Equip Random Weapon
                    player.EquippedWeapon = Weapon.GenerateRandomWeapon();
                    Console.WriteLine($"Equipped {player.EquippedWeapon.Name} with {player.EquippedWeapon.AttackBonus} attack bonus.");
                    break;

                case "4": // Exit
                    Console.WriteLine("Exiting game...");
                    gameRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    private void ShowMainMenu()
    {
        Console.WriteLine("\nMain Menu:");
        Console.WriteLine("1. Fight Monsters");
        Console.WriteLine("2. View Player Stats");
        Console.WriteLine("3. Equip Random Weapon");
        Console.WriteLine("4. Exit");
    }
}
