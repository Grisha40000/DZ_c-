// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// bool Number(int number)
// {
//     int num1=number%10;
//     int num2=number/10000;
//     int num3=number%100/10;
//     int num4=number/1000%10;
//     if(num1==num2||num3==num4)
//     {
//         return true;
//     }
//     else 
//     return false;
// }

// Console.Write("Введите пятизначное число :");
// int number=Convert.ToInt32(Console.ReadLine());
// bool result=Number(number);
// Console.Write(result);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.

// double ShowQuart(double x1 ,double x2,double y1,double y2,double z1,double z2 )
// {
//     double x =x2-x1;
//     double y =y2-y1;
//     double z =z1-z2;
    
//     double dot=Math.Sqrt(x*x+y*y+z*z);
//     return dot;
// }
// Console.Write("Введите x1:");
// double x1=Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите y1:");
// double y1=Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите z1:");
// double z1=Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите x2:");
// double x2=Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите y2:");
// double y2=Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите z2:");
// double z2=Convert.ToDouble(Console.ReadLine());

// double res=ShowQuart(x1,x2,y1,y2,z1,z2);
// Console.Write("Растоение ="+ res);



// Задача 23 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// void Show(int N)
// {
//     int index=1;

//     while (index<=N)
//     {
        
//         Console.Write(index*index*index +" ");
//         index++;
//     }
// }
// Console.Write("Введите N : ");
// int N =Convert.ToInt32(Console.ReadLine());
// Show(N);
