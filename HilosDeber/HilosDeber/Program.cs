using System;
using System.Threading;

namespace HilosDeber
{
    class Program
    {



        public static bool ejecutar = true;
        public static int conteo = 0;


        static void Main(string[] args)
        {

            ThreadPool.QueueUserWorkItem(Incremento, 25);
            Thread.Sleep(1000);

            Console.WriteLine("El valor final del conteo es {0}", conteo);

        }

        static void Incremento(object data)
        {
            int limite = (int)data;




            while (ejecutar)
            {
                conteo = conteo + 1;

                Console.Write(Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("{0}", conteo);

                if (conteo > limite)
                {
                    ejecutar = false;
                }

            }
        }
    }
}

