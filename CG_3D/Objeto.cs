using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_3D
{
    class Objeto
    {
        List<Vertice> originais;
        List<Face> faces;

        public Objeto() {
            originais = new List<Vertice>();
            faces = new List<Face>();
        }

        public Objeto(List<Vertice> originais, List<Face> faces)
        {
            this.originais = originais;
            this.faces = faces;
        }
        

        public List<Vertice> Originais
        {
            get
            {
                return originais;
            }

            set
            {
                originais = value;
            }
        }

        public List<Face> Faces
        {
            get
            {
                return faces;
            }

            set
            {
                faces = value;
            }
        }

    }
}
