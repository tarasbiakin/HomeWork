using System;
namespace HomeWork{
    class Program{
        static void Main(){
            System.Console.WriteLine("Введите первое число");
            int a = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Введите второе число");
            int b = Convert.ToInt16(Console.ReadLine());
            
            
            if (a > b)
            {
                System.Console.WriteLine("А больше Б");
            }
            else if (a < b)
            {
                Console.WriteLine("А меньше Б");
            }
            else
            {
                Console.WriteLine("Они равны");
            }




        }
    }
}



