﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
String str = "Все четные числа: ";
for(int i = 1; i <= n; i++){
if (i%2 == 0){
    str = str + i + " ";
}
}
System.Console.WriteLine(str);
