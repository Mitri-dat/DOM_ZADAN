﻿//  Написать программу которая выводит случайное трехзначное число а затем убирает вторую цифру


// Сгенерировать случайное число
// Показать наибольшую цифру
// Сравнить переменные и выбрать наибольшее

int num = new Random().Next(100,1000);


int digit1 = num / 100;
int digit2 = num % 10;

int second = (num - (digit1*100) - digit2)/10;

Consle.WriteLine($" {digit2}  {num} -> {second}");
