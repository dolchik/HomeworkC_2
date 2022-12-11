// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите номер дня недели: ");
int numDay = int.Parse(Console.ReadLine());

if ((numDay == 6) || (numDay == 7)) // проверка на соответсвие выходным
{
     Console.WriteLine($"{numDay} -> да");
}
else if ((numDay > 0) && (numDay < 6))
{
    Console.WriteLine($"{numDay} -> нет");
}
else
{
    Console.WriteLine($"{numDay} - неверный номер недели");
}
