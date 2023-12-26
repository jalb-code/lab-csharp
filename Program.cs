using LabCSharp.Async;

Console.WriteLine("Lab C#");

var separation = new String('-', 25);

// Async
// https://learn.microsoft.com/fr-fr/dotnet/csharp/asynchronous-programming/

Console.WriteLine(separation);
Console.WriteLine("Async - Exemple 1 - SyncProgram");
Console.WriteLine(separation);
SyncProgram.run();

Console.WriteLine(separation);
Console.WriteLine("Async - Exemple 1 - AsyncProgram");
Console.WriteLine(separation);
await AsyncProgram.run();

Console.WriteLine();

