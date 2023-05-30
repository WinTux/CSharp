using Algebraicas.Matriciales;
using Trigonometricas;

namespace zona_principal
{
    internal class Program
    {
        int var_global = 9;
        static void Main(string[] args)
        {

            /*
             ***************************************
             * PROYECTO open source GNU
             * 
             * Autor: Pepe
             ***************************************
             */
            int ladoX = 2;
            int ladoY = 4;
            int radio = 5;

            int potencia = 9;

            int cant_quinua = 34;

            //carnet de identidad
            int ci = 9876543;
            //numero de identificación tributaria
            int nit = 987654016;

            float peso = 12.0f;

            double gravedad = 9.8;

            double micro = peso + gravedad / 0;

            float x2 = 3.1416f;

            Console.WriteLine(x2);

            int res = (int)x2;
            Console.WriteLine(res);

            Console.WriteLine("¡Hola mundo!");

            string apellido = "Perales";

            var nombre = "Pepe";
            var edad = 20;
            var w = 56.7;

            string numeroTexto = "25";
            edad = int.Parse(numeroTexto);
            Console.WriteLine(edad);

            //usando clases propias
            Circulo c;
            MatrizPerspectiva matriz1;

            Algebraicas.Sumatorias sum;
            Algebraicas.Sumatorias sum2;

            otro.una_clase cc;

            Console.WriteLine("Ingrese un número (diferente a cero)");
            string valorUsuario = Console.ReadLine();
            int numeroMisterioso = int.Parse(valorUsuario);
            int x = 0;//hablar sobre esto
            try {
                x = 50 / numeroMisterioso;
            } catch (DivideByZeroException e)
            {
                Console.WriteLine("Por favor, intente de nuevo, usted ingresó el numero 0.");
            }

            Console.WriteLine("La división es: " + x);
        }

        public void metodito() {
            int x = 3 * var_global;
        }
    }
}

namespace otro
{
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class una_clase
    {
        Circulo circulo2;
        string nn;
        int y = 9;
        public void met() { 
            
        }
    }
}