//  Написать программу которая на вход принимает два числа и определяет, является ли второе, кратным первому
// например: 34, 5 -> не кратно, остаток 4 

Console.WriteLine("Введите первое число : ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int number2 = int.Parse(Console.ReadLine());

int ost = number1 % number2;
if (ost > 0 )Console.WriteLine($" Остаток {ost}");
    else  Console.WriteLine($" {number1}, {number2} кратно");  
 