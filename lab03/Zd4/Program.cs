Console.Write("Health: ");
int health = int.Parse(Console.ReadLine()!);

Console.Write("Have key (true/false): ");
bool haveKey = bool.Parse(Console.ReadLine()!);

Console.Write("Knows passowrd (true/false): ");
bool knowsPassword = bool.Parse(Console.ReadLine()!);

if(health <= 0) {
  Console.WriteLine("Dead");
}
else if(haveKey || knowsPassword) {
  Console.WriteLine("Can enter");
}
else {
  Console.WriteLine("Cannot enter");
}
