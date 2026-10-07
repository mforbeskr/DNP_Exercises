using Library;

var b1 = new TheBook();
b1.Name = "Best Book Ever";
b1.ReleaseYear = 2024;
b1.Author="Austin";

Console.WriteLine(b1);
Console.WriteLine();
b1.Inspect();