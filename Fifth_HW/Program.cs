// Показать последнюю цифру трёхзначного числа

Console.Clear();
Console.WriteLine();

int number = new Random().Next(100, 999);

Console.WriteLine($"Последняя цифра числа {number} - это цифра {number%10}");
Console.WriteLine();
