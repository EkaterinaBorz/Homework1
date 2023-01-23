// Удалить вторую цифру трёхзначного числа

Console.Clear();
Console.WriteLine();

int Number = new Random().Next(100, 999);
int NewNumber = 0;

int NumberWithoutSecondDigit()
{
    NewNumber = Number / 100 * 10 + Number % 10;
    return NewNumber;
}

NumberWithoutSecondDigit();

Console.WriteLine();
Console.WriteLine($"Если из числа {Number} удалить вторую цифру, получится число {NewNumber}");
Console.WriteLine();
