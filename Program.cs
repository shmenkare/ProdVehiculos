using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProdVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            //V2.0 con funciones agragadas.
            
            int i = 0, j = 0, ventaDia = 0, totDias = 20,cantMay = 0, cantMen = 100;
            float sum = 1.0f, prom = 1.0f;
            
            int [,] VentaSemanal = new int [4,5];


            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("Cantidad de vehiculos producidos en el dia {0}{1}", i, j);
                    ventaDia = Convert.ToInt32(Console.ReadLine());
                    VentaSemanal[i, j] = ventaDia;
                    sum += ventaDia;
                    Console.Clear();
                }
            }
            MostrarTabla(VentaSemanal);
            
            prom = Promedio(sum, totDias);
            Console.WriteLine("El promedio de ventas es {0} ", prom);

            cantMen = Menor(VentaSemanal, cantMen);
            cantMay = Mayor(VentaSemanal, cantMay);

            Console.WriteLine("La menor cantidad producida es {0} ", cantMen);
            Console.WriteLine("La mayor cantidad producida es {0} ", cantMay);
            
            Console.ReadKey();
            
        }
        static void MostrarTabla(int [,] Array)
        {
            int i = 0, j = 0;
            Console.WriteLine("Mostrando tabla");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Thread.Sleep(100);
                    Console.Write(Array[i, j]+" ");
                    
                }
                Console.WriteLine();
            }
        }
        static int Menor(int [,]Array, int valor)
        {
            int i = 0, j = 0;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (Array[i, j] < valor)
                    {
                        valor = Array[i,j];
                    }
                }
                
            }
            return valor;
        }
        static int Mayor(int [,] Array, int valor) 
        {
            int i = 0, j = 0;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (Array[i, j] > valor)
                    {
                        valor = Array[i, j];
                    }
                }

            }
            return valor;
        }
        static float Promedio(float a, float b) 
        {
            float res = a / b;
            return res;
        }
        
    }
}
