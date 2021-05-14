using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matris1 = { { 10,20,30,40}, {50,60,70,80} };

            int[,] matris2 = { {5,15,25,35 }, {45,55,65,75 } };

            Console.WriteLine("ilk matrisin görüntüsü aşağıda ki gibidir;");

            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write("  {0}  ", matris1[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("ikinci matrisin görüntüsü aşağıdaki şekildeki gibidir;");

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 4; j++)
                
                    Console.Write("  {0}  ", matris2[i, j]);
                Console.WriteLine();
            }

            int[,] toplam = new int[2, 4];

            Console.WriteLine("matris1 ve matris2 nin toplamından oluşan toplam matrisi aşağıdaki gibidir");

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 4; j++)
                                        
                   
                   Console.Write("  {0}  ", (toplam[i,j]=matris1[i,j]+matris2[i,j]));    
                                
                
                Console.WriteLine(); 
                
            }






            Console.Read();

        }
    }
}
