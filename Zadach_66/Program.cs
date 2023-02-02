/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
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
        
int SumDiap(int m, int n) 
  {
    int sum=n;
    if (m==n)
      {
        return sum;
      }
    return m+SumDiap(m+1,n);
  }
    
int M= NumInt("Введите начало диапазона: ");
int N= NumInt("Введите начало диапазона: ");
    
Console.WriteLine("Сумма натуральных элементов в промежутке от {0} до {1} = {2} ", M, N, SumDiap(M, N));