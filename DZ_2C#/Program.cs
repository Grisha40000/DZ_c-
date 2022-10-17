//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

int Number2(int number)
{
    
    int des2= number%100/10;
    number=des2;
    return number;
}
Console.Write("Введите трехзначное число:");
int num=Convert.ToInt32(Console.ReadLine());

int result=Number2(num);
Console.Write($" Внесенное число {num} полученное число  {result}");
//234