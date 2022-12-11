// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
// int number = new Random().Next();        //рандомное число
// Console.WriteLine(number);

Console.Write("Введите число: ");           
int number = int.Parse(Console.ReadLine());
int number1 = number;
int ostatok = 0;

while (number1 > 999)
{
    number1 = number1 / 10;
    Console.WriteLine(number1);
}
    
if (number1 > 99)
{
    ostatok = number1 % 10;
    Console.WriteLine($"{number} -> {ostatok}");
}
    
else
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}

