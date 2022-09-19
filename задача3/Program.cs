Console.Write("введите число -> ");
int val12 = Convert.ToInt32(Console.ReadLine());

int val = val12 % 2;

if (val == 1) Console.WriteLine($"Нет");
else Console.WriteLine($"Да");