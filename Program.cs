using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve İşlemli Atama

            int x=3;
            int y=5;

            y=y+2;
            y+=2;
            y/=1;
            x *=2;

            //Mantıksal Operatörler

            bool isSuccess = true;
            bool isCompleted= false;

            if(isSuccess && isCompleted) //ve
                Console.WriteLine("Perfect");

           if(isSuccess || isCompleted) //veya
                Console.WriteLine("Great");

        
            if(isSuccess && !isCompleted) //ve değil
                Console.WriteLine("Perfect");

            //İlişkisel operatörler
            //<, >, >=, <=, !=, ==


            // % mod almak için kullanılır.





        }
    }
}
