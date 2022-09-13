/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

/*Console.Clear();
Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()); // int.Parse(Console.ReadLine()) -переводит написанное в консоли в int
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
int Degree(int num)
{
    int count = numberB;
    while (count < numberB) // 
    {
        num *= count;
        count++;
        Console.WriteLine(num);
    }
    return num; // возвращаем 
}
Console.WriteLine($"{numberA},{numberB} -> {Degree(numberB)}");*/

Console.WriteLine("введите число A");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("введите число B");
int numberB = int.Parse(Console.ReadLine());
int Degree = numberA;

for (int i = 1; i < numberB; i++)
{
Degree = Degree * numberA;
}
//Console.WriteLine("A в степени B равно: " + Degree);
Console.WriteLine($"{numberA},{numberB} -> {(Degree)}");