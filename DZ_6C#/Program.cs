// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


// Console.WriteLine("Введите колличество чисел в массиве:");
// int m=Convert.ToInt32(Console.ReadLine());

// int res=Positive(m);
// Console.WriteLine($"количество значений больше 0 = {res}");


// int Positive(int m)
// {
//     int count=0;
//     for(int i=0;i<m;i++)
//     {
//         Console.WriteLine("Введите число");
//         int a=Convert.ToInt32(Console.ReadLine());
//         if(a>0)
//         {
//             count++;
//         }
//     }
//     return count;
// }


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2

// Console.WriteLine("Введите k1:");
// double k1=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите b1:");
// double b1=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите k2:");
// double k2=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите b2:");
// double b2=Convert.ToDouble(Console.ReadLine());
// double x=(b2-b1)/(k1-k2);
// double y=k1*(b2-b1)/(k1-k2)+b1;
// Console.WriteLine($"Точка пересечения прямых={x};{y}");