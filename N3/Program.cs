﻿// Задача 3: 
//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
 static void print(int [] A, int n) 
    { 
      if (n > 0) 
      { 
      	Console.Write(A[n] + " "); 
      	print(A, n - 1); 
      } 
      else Console.WriteLine(A[0]); 
    } 
      int [] num = {1, 2, 5, 0, 10, 34}; 
      print(num, num.Length - 1); 
    