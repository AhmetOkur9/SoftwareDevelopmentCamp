using System.IO.Pipes;

List<string> names = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
Console.WriteLine(names[0]);
Console.WriteLine(names[1]);
Console.WriteLine(names[2]);
Console.WriteLine(names[3]);
names.Add("İlker");
Console.WriteLine(names[4]);
Console.WriteLine(names[0]);