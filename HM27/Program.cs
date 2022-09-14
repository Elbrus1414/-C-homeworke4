Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
/*Console.WriteLine("Введите число:  ");
int num = int.Parse(Console.ReadLine());

int a1 = num / 100;                             
int a2 = (num - (a1 * 100))/10;
int a3 = num % 10;
Console.WriteLine($"{num} -> {a1+a2+a3}");*/




Console.WriteLine("Введите число: ");
int i = int.Parse(Console.ReadLine());
int sum = 0;
while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine($"Сумма цифр в числе -> {sum}");

