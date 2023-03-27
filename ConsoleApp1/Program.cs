using System;
using static System.Console;
internal class Program
{
    private static void Main()
    {
        int A, B;
        A = Convert.ToInt32(ReadLine());  
        B = Convert.ToInt32(ReadLine());
        for (int i = A; i < B + 1; i++)
        {
            for (int j = 0; j < A; j++)
            {
                Write(A);
            }
            A++;
            WriteLine("");
        }
    }
}