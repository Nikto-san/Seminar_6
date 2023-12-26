// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 

// a b c => “abcdef”
// d e f 


using System;
using System.Text;

class Program
{
    static void Main()
    {
        char[,] charArray = {
    { 'A', 'B', 'C', 'D' },
    { 'E', 'F', 'G', 'H' },
    { 'I', 'J', 'K', 'L' }
};
        string str = "";
        StringBuilder strB = new StringBuilder();
        for (int i = 0; i < charArray.GetLength(0); i++)
        {
            for (int j = 0; j < charArray.GetLength(1); j++)
            {
                strB.Append(charArray[i,j]);
            }
        }
        Console.WriteLine($"{strB.ToString()}" + " ");
    }
}