Console.WriteLine("Напишите программу, которая на вход принимает два целых числа\r\nи выдаёт, какое число большее, а какое меньшее.\r\n");

Console.WriteLine("Введите первое число:");

bool res = int.TryParse(Console.ReadLine(), out int firstNumber);
if (!res)
{
    Console.WriteLine("Ошибка ввода.\r\nВыполнение программы будет остановлено.");
    return;
}

Console.WriteLine("Введите второе число:");

res = int.TryParse(Console.ReadLine(), out int secondNumber);
if (!res)
{
    Console.WriteLine("Ошибка ввода.\r\nВыполнение программы будет остановлено.");
    return;
}

Console.WriteLine($"Максиальное введенное число: {(firstNumber > secondNumber ? firstNumber : secondNumber)}");