using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_3D
{
    class Face
    {
        List<int> vertices;
        Vertice normal;

        public Face() {
            vertices = new List<int>();
        }
        public List<int> Vertices
        {
            get
            {
                return vertices;
            }

            set
            {
                vertices = value;
            }
        }

        
    }
}
