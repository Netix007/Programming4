// Задача 28: Подсчитать сумму цифр в числе

int SumOfDigits(int number) // Метод "Вычисление суммы цифр в числе"
{
    int sum = 0;
    for (int i = 1; number / i >= 1; i *= 10)
    {
        sum = sum + ((number / i) % 10);
    }
    return sum;
}

int number = new Random().Next(0,10000);
int sum = SumOfDigits(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");
