using System;
namespace HomeWork{
    class Program{
        static void Main(){
            System.Console.WriteLine("Введите  число");
            int a = Convert.ToInt16(Console.ReadLine());
             
            if (a %2== 0)
            System.Console.WriteLine("Число четное");
            else
              Console.WriteLine("Число нечетное");
        }
 
    }
}           