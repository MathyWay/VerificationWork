string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
int i = 0;
int count = 0;
while (i < array.Length)
{
    if(array[i].Length <= 3) count++;
    i++;
}
Console.WriteLine($"Количество элементов равно {count}");