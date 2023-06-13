// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
//int max = 0;
System.Console.WriteLine("Введите три числa:");
int max = Convert.ToInt32(Console.ReadLine());
int p2 = Convert.ToInt32(Console.ReadLine());
int p3 = Convert.ToInt32(Console.ReadLine());
if (max<p2){
    max = p2;
}
if(max < p3){
    max = p3;
}
System.Console.WriteLine($"Максимальное число = {max}");