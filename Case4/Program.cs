using System;
namespace HomeWork{
    class Program{
        static void Main(){
             System.Console.WriteLine("Введите первое число");
            int a = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Введите второе число");
            int b = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Введите третье число");
            int c = Convert.ToInt16(Console.ReadLine());

            int max = 0;
            if (a > b)max = a;
            else
            {
                max = b;
            }
            if(c > max) {max =c;
                Console.WriteLine($"max  " + max);}
             
            else
             
                Console.WriteLine($"max  " + max);
             
              
      }
    }
}


