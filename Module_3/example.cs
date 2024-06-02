var o = new Octopus ("Jack", 5);
Console.WriteLine($"Octopus {o.Name} has {o.Legs} legs and {o.eyes} eyes");

class Octopus
{
  public readonly string Name;
  public int Age;
  public readonly int Legs = 8, eyes = 2;
  
  public Octopus (string name, int age)
  {
    Name = name;
    Age = age;
  }
}