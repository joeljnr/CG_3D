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

        public double X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public double Z
        {
            get
            {
                return z;
            }

            set
            {
                z = value;
            }
        }
        public double Nx
        {
            get
            {
                return nx;
            }

            set
            {
                nx = value;
            }
        }
        public double Ny
        {
            get
            {
                return ny;
            }

            set
            {
                ny = value;
            }
        }
        public double Nz
        {
            get
            {
                return nz;
            }

            set
            {
                nz = value;
            }
        }


    }
}
