// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Случайное число:
// Random rand = new Random();
// int x = rand.Next (100, 1000);
// Console.WriteLine(x);

// Ручной ввод трехзначного числа:
int x;
Console.WriteLine("Введите  трехзначное число: ");
x = Convert.ToInt32(Console.ReadLine());
if(x > 99 && x < 1000)
{
    int a1 = x / 10;
    int a2 = a1 % 10;
    Console.Write("Второй цифрой числа "+ x + " является: " + a2);
}
else{
    Console.WriteLine("Число не трехзначное! Повторите");
}
