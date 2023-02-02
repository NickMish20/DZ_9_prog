 /*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
Console.Clear();    
int NumInt (string mes= "Ведите целое число: ", string error = "Вы ввели не корректное значение!")   
  {
    Console.Write(mes);
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))  
      {
        Console.WriteLine(error);
        Console.Write(mes);
      }
    return num;
  }
        
void SetNumder(int m, int n=1) 
  {
    Console.Write("{0} ", m);
    if (m==n)
      {
        return;
      }
    SetNumder(m-1, n=1);
  }
    
int N= NumInt("Введите начало диапазона: ");
    
Console.Write("Натуральные числа в промежутке от {0} до 1 => ", N); 
  
SetNumder(N);
