//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8){
if (number == 6) {
    Console.WriteLine("Это выходной день - суббота!");
}
else if (number == 7){
    Console.WriteLine("Это выходной день - воскресенье!");
}
else{
    Console.WriteLine("Это будний день!");
}
}
else {
    Console.WriteLine("Вы ввели некорректную цифру! Введите цифру от 1 до 7");
}