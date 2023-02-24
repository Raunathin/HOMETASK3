using System;

namespace project
{
class Programm
{
static void Main()
{
/*
Задача 19 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Clear();

System.Console.WriteLine("Введите 5-ти значное число: ");

string number = Console.ReadLine();
int LengthNumber = number.Length;

if(LengthNumber == 5){
    if(number[0] == number[4] && number[1] == number[3]){
        System.Console.WriteLine($"Число {number} палиндром");
    }
    else{
        System.Console.WriteLine($"Число {number} не палиндром");
    }
}
else{
    System.Console.WriteLine($"Число {number} не 5-ти значное");
}
}
     }

}   