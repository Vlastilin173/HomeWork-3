// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 10000 || n > 99999)
{
    Console.Write($"{n} Не является пятизначным числом");
    return;
}
int n1 = n / 10000;
Console.WriteLine(n1);
int n2 = n / 1000 % 10;
Console.WriteLine(n2);
int n4 = n / 10 % 10;
Console.WriteLine(n4);
int n5 = n % 10;
Console.WriteLine(n5);
if (n1 == n5 && n2 == n4)
{
    Console.WriteLine ($"{n} Является палиндромом");
}
else
{
    Console.WriteLine ($"{n} Не является палиндромом");
}


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координату X(1): ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y(1): ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z(1): ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату X(2): ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y(2): ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z(2): ");
double z2 = Convert.ToDouble(Console.ReadLine());

double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine(Math.Round(S, 2));


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
  Console.WriteLine($" {i} ^ 3 = {i * i * i} ");