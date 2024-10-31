// See https://aka.ms/new-console-template for more information
using Lab1.Constructions;
using Lab1.Constructions.Dto;

Console.WriteLine("Hello, World!");
var constaction1 = new Construction();
var constaction2 = new Construction(23, 45, 4, 4, "Material");
var constaction3 = new Construction(
    new CreateConstructionDto()) {
    Height = 100
    Width = 200;
    BuildMaterial = "Material";
};


Console.WriteLine(constaction2.BuildMaterial);
Console.WriteLine(constaction2.Width);
Console.WriteLine(constaction2.Height);
Console.WriteLine(constaction2.Entrances);
Console.WriteLine(constaction2.HumanCapacity);

Console.WriteLine(constaction1.BuildMaterial);
Console.WriteLine(constaction1.Width);
Console.WriteLine(constaction1.Height);
Console.WriteLine(constaction1.Entrances);
Console.WriteLine(constaction1.HumanCapacity);

