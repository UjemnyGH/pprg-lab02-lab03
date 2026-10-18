Console.Write("Direction (west, east, north, south): ");
string dir = Console.ReadLine()!;

switch(dir) {
  case "north":
    Console.WriteLine("Hills");
    break;

  case "south":
    Console.WriteLine("Desert");
    break;

  case "east":
    Console.WriteLine("Forest");
    break;
  
  case "west":
    Console.WriteLine("Sea");
    break;
}
