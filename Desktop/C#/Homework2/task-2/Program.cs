// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int usl = int.Parse(Console.ReadLine());

int number = usl;


while (number > 999)
{
    number=number/10;
}
int sot = (number - ((number/10)*10));

if (usl < 100)Console.WriteLine("Третьей цифры нет");
else
{
    Console.WriteLine($"Третья цифра числа {usl}: {sot} ");
    }



