//Задача №4. Ввести число, вывести все четные числа от 1 до этого числа
//Вариант 1. Решение через count + 2
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int count = 2;
Console.Write($"Все четные числа до числа {number}: ");
while (count <= number)   //или если исключая введенное число, то whail (count <= number-1)
{
    Console.Write($"{count} ");
    count = count + 2;
}
Console.WriteLine();

//Вариант 2. Решение через %
Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
int count1 = 1;
Console.Write($"Все четные числа до числа {number1}: ");
while (count1 <= number1)   //или если исключая введенное число, то whail (count <= number-1)
{
    int x = count1 % 2;
    if (x == 0)
    {
        Console.Write($"{count1} ");
    }
    count1++;
}