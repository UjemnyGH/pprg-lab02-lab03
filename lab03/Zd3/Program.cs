Console.Write("Age: ");
int age = int.Parse(Console.ReadLine()!);

if(age < 0) {
  Console.WriteLine("Wrong age");
}
else if(age >= 0 && age < 13) {
  Console.WriteLine("Kid");
}
else if(age >= 13 && age < 18) {
  Console.WriteLine("Teen");
}
else if(age >= 18 && age < 65) {
  Console.WriteLine("Adult");
}
else {
  Console.WriteLine("Senior");
}
