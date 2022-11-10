// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет
//  количество чётных чисел в массиве.

// int[] CreateRandomArray(int size)
// {
//     int[] array=new int[size];
    
//     for(int i=0;i<size;i++)
//     {
//         array[i]=new Random().Next(100,1000);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i=0;i<array.Length;i++)
//         Console.Write(array[i]+" ");

//     Console.WriteLine();    
// }

// int Parity(int[] array)
// {
//     int count=0;
//     for(int i=0;i<array.Length;i++)
//     {
//         if(array[i]%2==0)
//             count++;
//     }
//     return count;
// }

// Console.Write("Input a number of elements:");
// int elements=Convert.ToInt32(Console.ReadLine());


// int[] myArray=CreateRandomArray(elements);
// ShowArray(myArray);
// int res=Parity(myArray);
// Console.WriteLine($"Количество чётных чисел={res}");



// Задача 36: Задайте одномерный массив,
//  заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray(int size,int minValue,int maxValue)
// {
//     int[] array=new int[size];
    
//     for(int i=0;i<size;i++)
//     {
//         array[i]=new Random().Next(minValue,maxValue+1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i=0;i<array.Length;i++)
//         Console.Write(array[i]+" ");

//     Console.WriteLine();    
// }
// int OddnessSum(int[] array)
// {
//     int sum=0;
//     for(int i=1;i<array.Length;i=i+2)
//     {
//         sum=sum+array[i];
//     }
//     return sum;
// }
// Console.Write("Input a number of elements");
// int n=Convert.ToInt32(Console.ReadLine());
// Console.Write("Inputa min possible value:");
// int min=Convert.ToInt32(Console.ReadLine());
// Console.Write("Inputa max possible value:");
// int max=Convert.ToInt32(Console.ReadLine());

// int[] myArray=CreateRandomArray(n,min,max);
// ShowArray(myArray);
// int res=OddnessSum(myArray);
// Console.WriteLine("Cумму нечётных элементов=" + res);


// Задача 38: Задайте массив вещественных чисел. Найдите
//  разницу между максимальным и минимальным элементов массива.

// double[] CreateRandomArray(int size,int minValue,int maxValue)
// {
//     double[] array=new double[size];
    
//     Random rand = new Random();
//     for(int i=0;i<size;i++)
//     {
//         array[i]=rand.Next(minValue,maxValue) +rand.NextDouble();
//     }
//     return array;
// }
// void ShowArray(double[] array)
// {
//     for(int i=0;i<array.Length;i++)
//         Console.Write(array[i]+" ");

//     Console.WriteLine();
// }
// double MinMax(double[] array,double min,double max)
// {
//     double min1=max;
//     double max1=min;
//     double dif=0;
//     for(int i=0;i<array.Length;i++)
//     {
//         if(array[i]>max1)
//             max1=array[i];
//         if(array[i]<min1)
//             min1=array[i];      
//     }
//     dif=max1-min1;
//     return dif;
// }

// Console.Write("Input a number of elements");
// int n=Convert.ToInt32(Console.ReadLine());
// Console.Write("Inputa min possible value:");
// int min=Convert.ToInt32(Console.ReadLine());
// Console.Write("Inputa max possible value:");
// int max=Convert.ToInt32(Console.ReadLine());

// double[] myArray=CreateRandomArray(n,min,max);
// ShowArray(myArray);
// double res=MinMax(myArray,min,max);
// Console.WriteLine("Разница между max and min="+ res);


// Интересная задача