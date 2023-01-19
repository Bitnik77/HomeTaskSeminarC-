//Задача №1. Ввести 2 числа, вывести какое из них больше, меньше
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
if (number1 > number2) Console.WriteLine($"Первое число {number1} большее, второе число {number2} меньшее");
if (number1 < number2) Console.WriteLine($"Первое число {number1} меньшее, второе число {number2} большее");
else if (number1 == number2) Console.WriteLine("Введенные числа равны");