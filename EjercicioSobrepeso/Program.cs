using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSobrepeso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repetir = false;
            do
            {
                Console.WriteLine("Bienvenido a la aplicación de salud");


                double indMcorporal = Imc();
                if (indMcorporal > 25)
                {
                    Console.WriteLine("Tiene sobrepeso");
                    Console.WriteLine("El riesgo de tener un infarto es del 62% con estrés y de un 18% si no lo tienes");



                }
                else if (indMcorporal < 24)
                {
                    Console.WriteLine("Estas en un buen estado de salud");
                    Console.WriteLine("El riesgo de tener un infarto es del 15% con estrés y de un 5% si no lo tienes");
                }

            }while (repetir==false);
            Console.ReadKey();
        }

        public static double Imc ()
        {
            
            double peso;
            double altura;
            Console.Write("Introduce tu peso:");
            peso= double.Parse(Console.ReadLine());
            Console.Write("Introduce tu altura en cm:");
            altura = double.Parse(Console.ReadLine());


            double imc= peso/((altura/100)*(altura/100));

            Console.WriteLine("Tu imc es: {0}",imc);

            return imc;
        }

        
            

    }
}
