// Показать вторую цифру трёхзначного числа

Console.Clear();
Console.WriteLine();

int number = new Random().Next(100, 999);

Console.WriteLine($"Вторая цифра числа {number} - это цифра {number/10 % 10}");
Console.WriteLine();
