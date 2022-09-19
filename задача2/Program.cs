Console.WriteLine("Введите число 1 -> ");
int val11 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2 -> ");
int val21 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 3 -> ");
int val31 = int.Parse(Console.ReadLine());

int max1 = val11;
if (max1 < val21) max1 = val21;
if (max1 < val31) max1 = val31;

Console.WriteLine($" Mаксимальное число:  {max1}");
