// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write($"Введите цифру от 1 до 7 \n");
int a = int.Parse(Console.ReadLine()!);
if (a<1 || a>7)
Console.Write($"Необходимо ввести цифру от 1 до 7 \n");
else 
{
    if (a == 6 || a == 7)
    {Console.Write($"да \n");}
    else {Console.Write($"Нет \n");}
}

