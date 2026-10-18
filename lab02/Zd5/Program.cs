Console.Write("Name: ");
string name = Console.ReadLine()!;

Console.Write("Max health: ");
int maxHealth = int.Parse(Console.ReadLine()!);

Console.Write("Health: ");
int health = int.Parse(Console.ReadLine()!);

Console.Write("Default weapon damage: ");
int weaponDamage = int.Parse(Console.ReadLine()!);

Console.Write("Strenght buff: ");
int strenghtBuff = int.Parse(Console.ReadLine()!);

Console.Write("Special attack multiplier: ");
double specialAttack = double.Parse(Console.ReadLine()!);

Console.Write("Amount of normal attacks: ");
int normalAttacksAmount = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Single attack damage: {weaponDamage + strenghtBuff}\nSpecial attack damage: {(int)((weaponDamage + strenghtBuff) * specialAttack)}");
Console.WriteLine($"Overall damage: {(weaponDamage + strenghtBuff) * normalAttacksAmount + (weaponDamage + strenghtBuff) * specialAttack}");
Console.WriteLine($"Health left: {((double)health / maxHealth) * 100.0}%\nIs alive: {health > 0}\nFull health: {health >= maxHealth}");
