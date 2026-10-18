Console.Write("Health: ");
int health = int.Parse(Console.ReadLine()!);

Console.Write("Potions: ");
int potions = int.Parse(Console.ReadLine()!);

Console.Write("Has key: ");
bool haveKey = bool.Parse(Console.ReadLine()!);

Console.Write("Has map: ");
bool haveMap = bool.Parse(Console.ReadLine()!);

bool alive = health > 0;
bool fullHealth = health == 100;
bool needHealing = !fullHealth;
bool isEquiped = potions > 0;
bool haveNavigationItem = haveKey || haveMap;
bool ready = alive && isEquiped && haveNavigationItem;

Console.WriteLine($"Alive: {alive}\nFull health: {fullHealth}\nNeed healing: {needHealing}\nIs equiped: {isEquiped}\nHave navigation item: {haveNavigationItem}");
Console.WriteLine($"Ready: {ready}");
