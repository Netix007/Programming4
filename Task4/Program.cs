// Задача 32: Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

Random randomizer = new Random();
int[] resultArray = new int[8];
for (int i = 0; i <= 7; i++)
{
    resultArray[i] = randomizer.Next(0, 2);
    Console.Write($"{resultArray[i]}  ");
}
