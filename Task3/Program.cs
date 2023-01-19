//Задача №3. Ввести число, вывести четное ли число
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int x = number % 2;
if (x == 0) Console.WriteLine($"Число {number} четное");
else Console.WriteLine($"Число {number} не четное");