// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введи число: ");
int newNumber = Convert.ToInt32(Console.ReadLine());
string newNumberText = Convert.ToString(newNumber);
if (newNumberText.Length > 2)
{
    Console.WriteLine("третья цифра -> " + newNumberText[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}