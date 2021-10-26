using System;

namespace Methodtlar_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region method-1


            /*Console.WriteLine("1ci parametri daxil edin:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2ci parametri daxil edin:");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = Number(a, b);
            int d = Number2(a, b);
          

            Console.WriteLine((a + "+" + b + "="+ c)  + " " + a + "*" + b + "=" + d);*/
            #endregion


            #region method-2
            /* Console.WriteLine("1ci parametri daxil edin:");
             int X = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("2ci parametri daxil edin:");
             int Y = Convert.ToInt32(Console.ReadLine());

             int sum = Num(X, Y);

             Console.WriteLine(sum);*/
            #endregion

            #region Task-1
           /* Console.WriteLine("1ci eded:" + " ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2ci eded:" + " ");
            int b = Convert.ToInt32(Console.ReadLine());

            int d = a + b;
            Console.WriteLine(d);*/
            #endregion

            #region Task-2
            Console.WriteLine("1ci eded:" + " ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("operatoru daxil et: ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("2ci eded:" + " ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("operatoru daxil et: ");
            char operation2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("3cü eded:" + " ");
            int c = Convert.ToInt32(Console.ReadLine());

            int d = 0;

            if (operation == '+' & operation2 == '*')
            {
                d = a + b * c;
                Console.WriteLine("cavab" + " " + d);
                
            }
                
             else if (operation == '+' & operation2 == '%')
            {
                d = (a + b) % c;
                Console.WriteLine("cavab" + " " + d);
               
            }
                
            /*else if (operation == '*')
                Console.WriteLine("cavab" + " " + );
            else if (operation == '/')
                Console.WriteLine("cavab" + " " + );
            else
                Console.WriteLine("sehv melumat");
                                                    */



            
            #endregion
        }

         static int Number(int a, int b)
          {
              int c = 0;
               c = a + b;
              return c;
         }
         static int Number2(int a, int b)
         {
             int d = 0;

             d = a * b;

             return d;


         }
         static int Num(int X, int Y)
         {
             int sum = 0;

             for (int i = 0; X <= Y; X++)
             {
                 sum = sum + X;

             }


             return sum;

         }


    } 
}

