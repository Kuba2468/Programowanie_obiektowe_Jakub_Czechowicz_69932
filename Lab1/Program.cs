// See https://aka.ms/new-console-template for more information
using Lab1.Constructions;

Console.WriteLine("Hello, World!");
var constaction1 = new Construction();
var constaction2 = new Construction(23, 45, 4, 4, "Material");
Console.WriteLine("Hello World!");
Console.WriteLine(constaction2.BuildMaterial);
Console.WriteLine(constaction2.Width);
Console.WriteLine(constaction2.Height);
Console.WriteLine(constaction2.Entrances);
Console.WriteLine(constaction2.HumanCapacity);
