using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control de verciones kkk666 ");
            Console.WriteLine("Control de verciones 2");
            Console.WriteLine("Control de verciones 3");
            Console.WriteLine("Control de verciones 4");
            Console.WriteLine(" 3 elevado a la 4 es igual a : {0}" , potencia (3, 4) );
            Console.ReadKey();

            try
            {
                Console.WriteLine(" 3 elevado a la 9 es igual a : {0}", potencia(3, 9));
            } catch (Exception ex)
            {
                Console.WriteLine(" Error: " + ex.Message.ToString());
            }

            try
            {
                Console.WriteLine(" -5 elvada a la 2 es igual  a : {0}", potencia(-5, 2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error: " + ex.Message.ToString());
            }
            Console.ReadKey();

        }
        public static double potencia(double x, double y)
        {
            double p = 1;
            for (int i = 1; i <= y; i++)
            {
                p = p * x;
            }
            return p;
        }

        public static double potencia(double x, int y)
        { 
            if (x <= 0)
            {
                throw new Exception("x debe ser positivo ..");
            }
            if( y <= 0)
            {
                throw new Exception(" y debe ser positivo ....");
            }
            double p = 1;
            for (int i = 1; i <= y; i++)
            {
                p = p * x;
            }
            return p;
            //Control de errores //

        }


    }
}
