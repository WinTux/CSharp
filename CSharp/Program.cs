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
            #region Tipos de dato
            int resultado =sumador(3, 67);
            Console.WriteLine("La suma es: " + resultado);
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
            char letra = 'a';

            var nombre = "Pepe";
            var edad = 20;
            var w = 56.7;

            bool casado = false; // true

            string numeroTexto = "25";
            edad = int.Parse(numeroTexto);
            Console.WriteLine(edad);
            #endregion

            #region Otros ejemplos
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

             resultado = sumador(2147483647, 1);
            Console.WriteLine("La suma es: " + resultado);
            #endregion

            #region Arreglos
            //unidimensional
            int[] ropero = new int[4];
            string[] argumentos = new string[0];
            ropero[2] = 45;
            ropero[0] = -12;
            ropero[3] = 123;
            ropero[1] = 9000;

            int[] aux = new int[6];
            aux[0] = ropero[0];
            ropero = aux;

            //bidimensional
            int[,] matrix = new int[4, 6]; // fila, columna
            matrix[2, 4] = 40;
            
            //multidimensionales
            int[,,,,] arr = new int[3,5,6,7,2];

            Console.WriteLine("ropero en el indice 1: " + ropero[1]);
            #endregion

            #region SobreArgs
            Console.WriteLine("args contiene esta cantidad de elementos: " + args.Length);
            #endregion

            #region bucles
            //también iteradores, loops

            //While: Cuando no sabemos cuantas veces iterar
            Console.WriteLine("Ingrese un numero por favor:");
            int eval = int.Parse(Console.ReadLine());
            while (eval >= 1) {
                Console.WriteLine("Estoy dentro del while " + eval);
                eval--;
            }
            eval = 11;
            Console.WriteLine("Ya acabó el while");

            Console.WriteLine("eval ahora vale: " + eval);
            Console.WriteLine("eval++ vale: " + eval++);
            Console.WriteLine("eval ahora vale: " + eval);
            Console.WriteLine("++eval vale: " + ++eval);
            Console.WriteLine("eval ahora vale: " + eval);
            int x1 = 4, x0 = 3;
            Console.WriteLine(x1++ - --x0);// 4 - 2

            eval+=6;
            eval -= 5;
            eval *= 4;
            eval /= 4;

            //for: cuando sabemos cuantas veces iterar
            for (int i = 1;i <= 10;i++) {
                Console.WriteLine("Estoy dentro del for " + i);
                i++;
            }
            Console.WriteLine("Ya acabó el for");
            #endregion

        }

        public void metodito() {
            int x = 3 * var_global;
        }
        public static int sumador(int a, int b) {
            Console.WriteLine("SUMA DE DOS NUMEROS");
            int suma = a + b;
            return suma;
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
        public void met(int nit) {
            nit = nit + 3;
        }
        public void met(string num)
        {
            num = num + 3;
        }
        public void met(int ci, string x)
        {
            ci = ci + 3;
        }
        public void met(string x, int ci) {
            registroEmpleado("Pepe","Perales");
            registroEmpleado("Lopez", "Sofia");
            
        }
        public void registroEmpleado(string Nombre, string Apellido) { 
            //bla bla bla
        }
    }
}