//Задача 25: Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.

// int Degree(int a,int b)
// {
//     int answer=1;
//     for(int index=1;index<=b;index++)
//     {
//         answer=answer*a;
//     }
//     return answer;
// }
// Console.WriteLine("Введите число:");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень:");
// int b=Convert.ToInt32(Console.ReadLine());
// int res=Degree(a,b);
// Console.WriteLine($"Answer{res}");


// Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.


//  int SumNumber(int number,int a)
// { 
    
//     int advance = 0;
//     int sum = 0;

//     for (int index = 0; index < a; index++)
//     {

//         advance = number - number % 10;
//         sum = sum + (number - advance);
//         number = number / 10;
//     }
//     return sum;
// }
// Console.WriteLine("Введите число:");
// int number=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество цифры:");
// int a=Convert.ToInt32(Console.ReadLine());


// int res = SumNumber(number,a);
// Console.WriteLine("Сумма цифр в числе: " + res);


// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.



// int[] Array = new int[8];
// for(int x=0;x<Array.Length;x++)
// {
//     Array[x]= new Random().Next(1,8);
//     Console.Write($"{Array[x]},");
// }

