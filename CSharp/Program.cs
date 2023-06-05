using Algebraicas.Matriciales;
using CSharp;

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
            //Circulo c;
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
                if (i == 4)
                    break;

                Console.WriteLine("Estoy dentro del for " + i);
                
            }
            Console.WriteLine("Ya acabó el for");
            #endregion

            #region Condicionales
            // < > <= >= == != .equals()
            // 
            Console.WriteLine("Iniciando IF");
            int y1=3, y2 = 5;

            if (y1 > y2) 
                Console.WriteLine("y1 es mayor a y2");
            else 
                Console.WriteLine("y1 NO es mayor a y2");
            

            Console.WriteLine("Continúa luego del IF");

            Console.WriteLine("Ingrese un numero de día (1: Lunes, 2: Martes, ... 7: Domingo)");
            int dia = int.Parse(Console.ReadLine());// 1: Lunes, 2: Martes, ... 7: Domingo
            if(dia == 1)
                Console.WriteLine("Lunes");
            else
                if(dia == 2)
                    Console.WriteLine("Martes");
                else
                    if(dia == 3)
                        Console.WriteLine("Miercoles");
                    else
                        if(dia == 4)
                            Console.WriteLine("Jueves");
                        else
                            if(dia == 5)
                                Console.WriteLine("Viernes");
                            else
                                if(dia == 6)
                                    Console.WriteLine("Sabado");
                                else
                                    if(dia == 7)
                                        Console.WriteLine("Domingo");
                                    else
                                        Console.WriteLine("No es un número de día.");

            switch (dia) {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Fin de semana");
                    break;
               
                default:
                    Console.WriteLine("No es un número de día.");
                    break;
            }

            #endregion

            #region OOP
            FiguraGeometrica fg1 = new FiguraGeometrica();

            FiguraGeometrica fg2 = new FiguraGeometrica("Circulo", 67f);
            fg1.Nombre = "Cuadrado";
            fg1.Area = -45.5f;
            Console.WriteLine($"La figura geométrica {fg1.Nombre} tiene como área {fg1.Area}[cm^2].");

            Cuadrado c1 = new Cuadrado();
            Console.WriteLine($"La figura geométrica {c1.Nombre} tiene como área {c1.Area}[cm^2].");

            Cuadrado c2 = new Cuadrado(12, 10);
            Console.WriteLine($"La figura geométrica {c2.Nombre} tiene como área {c2.Area}[cm^2].");

            Circulo cir1 = new Circulo(5, -1, 4);
            Console.WriteLine($"La figura geométrica {cir1.Nombre} tiene como área {cir1.Area}[cm^2].");

            FiguraGeometrica[] figuras = new FiguraGeometrica[3];
            figuras[0] = c1;
            figuras[1] = cir1;
            figuras[2] = c2;
            for(int i = 0; i < figuras.Length;i++)
                Console.WriteLine($"Elemento {i}: {figuras[i].Nombre} tiene como área {figuras[i].Area}[cm^2].");

            FiguraGeometrica fg3 = new Cuadrado();
            FiguraGeometrica fg4 = new Circulo();

            //Error
            //Cuadrado c3 = new FiguraGeometrica();
            //Circulo cir2 = new FiguraGeometrica();

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
        //Circulo circulo2;
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