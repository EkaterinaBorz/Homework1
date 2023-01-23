// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Clear();

int Number = new Random().Next(10, 99);
int Max = 0;

int MaxDigit()
{
    int Digit1 = Number / 10;
    int Digit2 = Number % 10;
    if (Digit1 > Digit2) Max = Digit1;
    else Max = Digit2;

    return Max;
}

MaxDigit();
Console.WriteLine();
Console.WriteLine($"В числе {Number} наибольшая цифра {Max}");
Console.WriteLine();