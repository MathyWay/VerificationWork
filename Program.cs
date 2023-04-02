string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .Where<string>(str => str.Length <= 3).ToArray();
foreach(string? item in array)
{
    Console.Write($"{item} ");
}
Console.WriteLine();