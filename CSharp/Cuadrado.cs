using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Cuadrado : FiguraGeometrica
    {
        private int x, y;
        public int X { get { return x; } set { x = X; } } 
        public int Y { get { return y; } set { y = Y; } }
    
        public Cuadrado() {
            X = Y = 1;
            Nombre = "Cuadrado";
        }
        public Cuadrado(int lado_x, int lado_y) : base("Cuadrado", lado_x * lado_y)
        {
            X = lado_x;
            Y = lado_y;
        }
    }

    public class Circulo : FiguraGeometrica
    {
        private int radio, x, y;
        public int Radio { get { return radio; } set { if(value>=0) radio = value; } }
        public int X { get { return x; } set { x = X; } }
        public int Y { get { return y; } set { y = Y; } }
        public Circulo()
        {
            X = Y = Radio = 0;
            Nombre = "Circulo";
        }
        public Circulo(int componente_x, int componente_y, int radio ) : base("Circulo", 3.1416f * radio * radio)
        {
            X = componente_x;
            Y = componente_y;
            Radio = radio;
        }
    }

    public class Paralelepipedo : FiguraGeometrica
    {
        
    }
}
