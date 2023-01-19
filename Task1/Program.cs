//Задача №1. Ввести 2 числа, вывести какое из них больше, меньше
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
if (number1 > number2) Console.WriteLine($"Первое число {number1} больше второго числа {number2}");
if (number1 < number2) Console.WriteLine($"Первое число {number1} меньше второго числа {number2}");
else if (number1 == number2) Console.WriteLine("Введенные числа равны");