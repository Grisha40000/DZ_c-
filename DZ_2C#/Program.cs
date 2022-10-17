//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

// int Number2(int number)
// {
    
//     int des2= number%100/10;
//     number=des2;
//     return number;
// }
// Console.Write("Введите трехзначное число:");
// int num=Convert.ToInt32(Console.ReadLine());

// int result=Number2(num);
// Console.Write($" Внесенное число {num} полученное число  {result}");

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// bool Weekend(int number)
// {
//     if(number==6||number==7) 
//     {
//         return true;
//     }
//     else
//     return false;

// }
// Console.Write("Введите число дня недели :");
//  int number=Convert.ToInt32(Console.ReadLine());
//  bool result=Weekend(number);
//  Console.Write(result);

//Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// int Number(int number,int b)//b=количестов символов в числе
// {
//     int index=3;
//     int not=-1;
//     if(index<=b)
//     {
//         while(index<b)
//         {   int sot=number/10;
//             number=sot;
//             index++;
//         }
//         int sot2=number%10;
//         number=sot2;
//         return number;
        
//     }
//     else
//     {
      
//        return  not;
//     }
     
// }
// Console.Write("Введите число:");
// int number=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количестов символов в числе:");
// int b=Convert.ToInt32(Console.ReadLine());
// int result=Number(number,b );
// Console.Write($"Внесенное число {number}  полученное {result}");