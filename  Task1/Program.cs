// Задача 26: Возведите число А в натуральную степень B используя цикл

Random randomizer = new Random();
int numberA = randomizer.Next(1,11);
int numberB = randomizer.Next(1,11);
double result = 1;

for (int i = 1; i <= numberB; i++)
{
    result = result * numberA;
}
Console.WriteLine($"{numberA}^{numberB} = {result}");
