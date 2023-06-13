// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
System.Console.WriteLine("Введите числo:");
int p = Convert.ToInt32(Console.ReadLine());
if(p%2 == 0){
    System.Console.WriteLine("Число четное");
}
else
    System.Console.WriteLine("Число нечетное");


