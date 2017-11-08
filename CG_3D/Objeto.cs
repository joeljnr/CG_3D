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
        List<Vertice> atuais;
        List<Face> faces;
        double[,] acumulada;

        public Objeto() {
            originais = new List<Vertice>();
            atuais = new List<Vertice>();
            faces = new List<Face>();
            acumulada = new double[4, 4] { { 1, 0, 0, 0 }, 
                                           { 0, 1, 0, 0 }, 
                                           { 0, 0, 1, 0 },
                                           { 0, 0, 0, 1 } };
        }

        public Objeto(List<Vertice> originais, List<Face> faces)
        {
            this.originais = originais;
            this.atuais = originais;
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

        public List<Vertice> Atuais
        {
            get
            {
                return atuais;
            }

            set
            {
                atuais = value;
            }
        }


        public double[,] multiplica4p4(double[,] m1, double[,] m2) {
            double[,] res = new double[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {  
                    for (int k = 0; k < 4; k++)
                    {
                        res[i,j] += m1[i,j] * m2[j,k];
                    }
                }
            }

            return res;
        }

        public double[,] multiplica4p1(double[,] m1, double[,] m2)
        {
            double[,] res = new double[4, 1];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 1; k++)
                    {
                        res[i, k] += m1[i, j] * m2[j, k];
                    }
                }
            }

            return res;
        }

        public void aplicaAtuais() {

            double[,] pto = new double[4, 1];
            double[,] res = new double[4, 1];
            pto[3, 0] = 1;

            for (int i = 0; i < atuais.Count; i++)
            {
                pto[0, 0] = atuais[i].X;
                pto[1, 0] = atuais[i].Y;
                pto[2, 0] = atuais[i].Z;

                res = multiplica4p1(pto, acumulada);

                atuais[i].X = res[0, 0];
                atuais[i].Y = res[1, 0];
                atuais[i].Z = res[2, 0];
            }


        }

        public void aplicaFaces()
        {

            double[,] pto = new double[4, 1];
            double[,] res = new double[4, 1];
            pto[3, 0] = 1;

            for (int i = 0; i < faces.Count; i++)
            {
                for(int j = 0; j < faces[i].Vertices.Count; j++)
                {
                    // calcula novas faces
                    pto[0, 0] = faces[i].Vertices[j].X;
                    pto[1, 0] = faces[i].Vertices[j].Y;
                    pto[2, 0] = faces[i].Vertices[j].Z;

                    res = multiplica4p1(pto, acumulada);

                    // atualiza novas faces
                    faces[i].Vertices[j].X = res[0, 0];
                    faces[i].Vertices[j].Y = res[1, 0];
                    faces[i].Vertices[j].Z = res[2, 0];
                }
            }
        }

        public void translacao(double x, double y, double z) {
            double[,] mat = new double[4,4] { { 1, 0, 0, x },
                                              { 0, 1, 0, y },
                                              { 0, 0, 1, z },
                                              { 0, 0, 0, 1 } };

            acumulada = multiplica4p4(mat, acumulada);
            aplicaAtuais();
            aplicaFaces();
            
        } 

    }
}
