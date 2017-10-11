using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_3D
{
    class Vertice
    {
        private double x, y, z, nx, ny, nz;

        public Vertice(double x, double y, double z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Nx { get; set; }
        public double Ny { get; set; }
        public double Nz { get; set; }

    }
}
