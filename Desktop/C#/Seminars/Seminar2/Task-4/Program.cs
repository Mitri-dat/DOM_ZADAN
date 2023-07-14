//  Задача 4. Написать программу которая на вход принимает  число и определяет, является ли оно кратным и 7 и 23.
// например: 161 -> Да

Console.WriteLine("Введите первое число : ");
int number = int.Parse(Console.ReadLine());

int ost1 = number % 7;
int ost2 = number % 23;

if (ost1 == 0 && ost2 == 0 )Console.WriteLine($" {number}, да");
    else  Console.WriteLine($" {number}, нет");
