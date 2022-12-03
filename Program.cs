// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write($"Введите число \n");
int a = int.Parse(Console.ReadLine()!);
if (a/100 == 0)
    { Console.Write($"Число двухзначное, третьей цифры нет");}
else {String b = String.Format("{0}", a);
Console.Write($"Третья цифра числа {a} = {b[2]}");}
