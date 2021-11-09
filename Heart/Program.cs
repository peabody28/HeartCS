using System;
using System.Threading;

namespace Heart
{
    class Program
    {
        public static Int32 Func(int x, int y)
        {
            return x * x + (int)((y - Math.Sqrt(Math.Abs(x))) * (y - Math.Abs(x)));
        }

        static void Main(string[] args)
        {
            Console.Title = "HABR @Frog_cry_too";
            Console.ForegroundColor = ConsoleColor.Red;
           

            Int32 height = 100, width = 100;
            char[,] buffer = new char[height, width];

            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);

            char[] love = { 'l', 'o', 'v', 'e' };
            int lv_i = 0;

            for (int i = 0; i < height; i++)
            {
                int y = -1 * (i - height / 2);
                for (int j = 0; j < width; j++)
                {
                    int x = j - width / 2;
                    
                    int heartSize = 500;
                    
                    if (Func(x,y) <= heartSize)
                    {
                        buffer[i, j] = love[lv_i];
                        lv_i = (lv_i + 1) % 4;
                    }
                    else
                        buffer[i, j] = ' ';
                }
                
            }
           
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                    Console.Write(buffer[i, j]);
                Thread.Sleep(100); 
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
