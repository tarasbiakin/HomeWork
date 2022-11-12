using System;
namespace HomeWork{
    class Program{
        static void Main(){
            
            int[] nums;

            System.Console.WriteLine("Введите  число");
            int N = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i + "Число четное");
                }else
                System.Console.WriteLine(i + "Число нечетное");
            }
           
        }
            
    }
}

