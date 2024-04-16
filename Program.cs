using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TextFile;
namespace Satisfactory2
{
    class Program
    {
        public static bool isFail(int a, int b, int c)
        {
            return ((a + b + c) / 3 * 100 <= 40);
        }

        public static int avg(int a,int b, int c)
        {
            return (a + b + c) / 3;
        }
        static void Main(string[] args)
        {
            string filepath = "C:\\Users\\alika\\source\\repos\\Satisfactory2\\input.txt";

            InpFile x = new InpFile(filepath);
            InpFile.Competitor c;
            
            int max = 0;
            string name = null;

            while(x.Read(out c))
            {
                
                if (isFail(c.first, c.second, c.third))
                {
                    break;
                }
                
                    
                    int avgg = avg(c.first, c.second, c.third);
                    if ( avgg > max)
                    {
                        max = avgg;
                    name = c.name;
                    }
                    

                



            }
            Console.WriteLine(name);

           



        }
    }
}
