/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
Console.Clear();      
int NumIntPol (string mes= "Ведите целое число: ", string error = "Вы ввели не корректное значение!")   
  {
    Console.Write(mes);
    int num;
    while (!int.TryParse(Console.ReadLine(), out num) || num<0)  
      {
        Console.WriteLine(error);
        Console.Write(mes);
      }
    return num;
  }
        
int Akker(int m, int n) 
  {
    
    if (m==0)
      {
        return n+1;
      }
    if (n==0)
      {
        return Akker(m-1, 1);
      }
     return Akker (m-1, Akker(m, n-1));
  }
    
int m=NumIntPol("Введите первое число функции Аккермана: ");
int n= NumIntPol("Введите второе число функции Аккермана: ");
    
Console.WriteLine("A({0}, {1})= {2} ", m, n, Akker(m, n));