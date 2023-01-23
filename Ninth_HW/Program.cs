// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Clear();
Console.WriteLine();

int Number1 = new Random().Next(50, 100);
int Number2 = new Random().Next(1, 50);
int result = 0;

int MultiNumber()
{
    result = Number1 % Number2;
    return result;
}

MultiNumber();

Console.WriteLine();
if (result == 0) Console.WriteLine($"Число {Number1} кратно числу {Number2}");
else
{
    Console.WriteLine($"Число {Number1} не кратно числу {Number2}, остаток равен {Number1 % Number2}");
}
Console.WriteLine();