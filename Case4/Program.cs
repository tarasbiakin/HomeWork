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
            if(a >b){
                max = a;
                 System.Console.WriteLine("Наибольшее число  " + max); }
                 else if(a<b){max = b;
                 System.Console.WriteLine("Наибольшее число  " + max);
                 }else if (c > max){
                    System.Console.WriteLine("Наибольшее число  " + max);
                 }

            
              
      }
    }
}


