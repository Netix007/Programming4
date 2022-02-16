// Задача 30: Показать кубы чисел, заканчивающихся на четную цифру

int[] RangeOfNumbers() // Медод "Задает начало и конец диапазона чисел"
{
    Random randomizer = new Random();
    int[] range = new int[2];
    range[0] = randomizer.Next(1, 100);
    do
    {
        range[1] = randomizer.Next(1, 100);
    } while (range[1] == range[0]);
    if (range[0] > range [1])
    {
        int max = range[0];
        range[0] = range[1];
        range[1] = max;
    }
    return range;
}

void GetResult(int[] range)
{
    for (int i = range[0]; i <= range[1]; i++)
    {
        if (i % 2 == 0)
            Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
    }
}

int[] range = RangeOfNumbers();
Console.WriteLine($"Кубы чисел в диапазоне [{range[0]},{range[1]}] и заканчивающихся на четную цифру");
GetResult(range);
