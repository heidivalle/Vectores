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
            Console.WriteLine(" 3 elevado a la 4 es igual a : {0}", potencia(3, 4));
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
            Console.WriteLine("2 elementos a la 5es igual a:{0} ", potencia(2, 5));
            //Console.WriteLine("LA NOTA 5 EQUIVALE A: a:{0}", NotaEquivalente(5));
            vectorInicializar();
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
            if (y <= 0)
            {
                throw new Exception(" y debe ser positivo ....");
            }
            double p = 1;
            for (int i = 1; i <= y; i++)
            {
                p = p * x;
            }
            return p;
            //*********************//


        }
        public static void vectorInicializar()
        {
            int[] x = new int[8];
            x[0] = 10;
            x[1] = 2;
            x[2] = 20;
            x[3] = 8;
            x[4] = 15;
            x[5] = 1;
            x[6] = -9;
            x[7] = 14;
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Elemento indice (0) ----->", (i + 1), x[i]);
            }           
                                          
                ¨//imprimir el vector
             Console.WriteLine("\nELEMENTOS DEL VECTOR\n==================\n");
            for (int i = 0;i<8;i++)
            {
                Console.WriteLine("Elememto indice{0} ---> {1}", (i + 1), x[i]);  

            }
        }
                                


        
        public static double potencia2(double x, int y)
        {
            if (x <= 0)
            {
                throw new Exception("x debe ser positivo..");
            }
            if (y <= 0)
            {
                throw new Exception("y debe ser positivo ...");
            }
            double p = 1;
            for (int i = 1; i <= y; i++)
            {
                p = p * x
            }
            return p;
        }
            
            

            
    }
}
    






    

