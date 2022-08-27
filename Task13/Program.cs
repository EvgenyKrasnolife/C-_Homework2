// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string StNumber = Convert.ToString(number);
if(StNumber.Length > 2){
    Console.WriteLine("Третьей цифрой числа " + number + " является " + StNumber[2]);
}
else{
    Console.WriteLine("Третьей цифры нет");
}