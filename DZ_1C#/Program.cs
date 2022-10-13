// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

if(A>B)
{
    Console.Write($"Max={A} Min={B}");
}
if(A == B)
{
    Console.Write($"{A} = {B}");
}
if (A<B)
{
    Console.Write($"Max={B} Min={A}");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третие число: ");
int c = Convert.ToInt32(Console.ReadLine());

 int max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;
Console.Write("Max=" + max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.Write("Введите число: ");
double A = Convert.ToDouble(Console.ReadLine());
double div =A/2;
if(div%2==0)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}
*/
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите количестов чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int current=0;
while(current<=n)
{
    int div = current/2;
    if(current%2==0)
    {
        Console.Write(current + " ");
        current++;
    }
    else
    {
        current++;
    }
}
