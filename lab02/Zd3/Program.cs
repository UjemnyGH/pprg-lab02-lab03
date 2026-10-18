Console.Write("Food amount: ");
int food = int.Parse(Console.ReadLine()!);

Console.Write("People amount: ");
int people = int.Parse(Console.ReadLine()!);

Console.Write("Days: ");
int days = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Food per person: {food / people}\nFood left: {food % people}");
Console.WriteLine($"Food per day: {(double)food / days}\nFood per person per day: {(double)(food / people) / days}");
