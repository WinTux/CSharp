using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class FiguraGeometrica
    {
        private string nombre;
        public string Nombre {
            get {
                return $"[Figura geométrica: {nombre}]";
            }
            set {
                nombre = value;
            }
        }
        private float area;
        public float Area
        {
            get
            {
                return area;
            }
            set
            {
                if (value >= 0)
                    area = value;
                else
                    Console.WriteLine("valor negativo, no se asigna a área; se conserva 0.");
            }
        }
        public FiguraGeometrica() {
            nombre = "NN";
            area = 0;
        }
        public FiguraGeometrica(string nombre, float area) {
            this.nombre = nombre;
            this.Area = area;
        }
    }
}
