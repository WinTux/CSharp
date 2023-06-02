using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class FiguraGeometrica
    {
        private string nombre;
        private float area;
        public FiguraGeometrica() {
            nombre = "NN";
            area = 0;
        }
        public FiguraGeometrica(string nombre, float area) {
            this.nombre = nombre;
            this.area = area;
        }
    }
}
