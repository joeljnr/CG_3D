﻿using System;
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

        public double[,] multMat(double[,] A, double[,] B, int LinhasA, int LinhasB, int ColunasA, int ColunasB)
        {
            double[,] C = new double[LinhasA, ColunasB];

            for (int i = 0; i < LinhasA; i++)
                for (int j = 0; j < ColunasB; j++)
                    for (int k = 0; k < LinhasB; k++)
                        C[i, j] += A[i, k] * B[k, j];

            return C;

        }
        public void aplicaAtuais() {

            double[,] pto = new double[4, 1];
            double[,] res = new double[4, 1];
            pto[3, 0] = 1;

            for (int i = 0; i < originais.Count; i++)
            {
                pto[0, 0] = originais[i].X;
                pto[1, 0] = originais[i].Y;
                pto[2, 0] = originais[i].Z;
                
                res = multMat(acumulada, pto, 4, 4, 4, 1);
                
                atuais[i].X = res[0, 0];
                atuais[i].Y = res[1, 0];
                atuais[i].Z = res[2, 0];
            }
            
        }

        public Vertice encontraPtoMedio() {
            double maiorx = 0, maiory = 0, maiorz = 0;
            double menorx = 99999, menory = 99999, menorz = 99999;

            for (int i = 0; i < originais.Count; i++) {
                if (originais[i].X > maiorx)
                    maiorx = originais[i].X;
                else
                    if (originais[i].X < menorx)
                        menorx = originais[i].X;

                if (originais[i].Y > maiory)
                    maiory = originais[i].Y;
                else
                    if (originais[i].Y < menory)
                    menory = originais[i].Y;

                if (originais[i].Z > maiorz)
                    maiorz = originais[i].Z;
                else
                    if (originais[i].Z < menorz)
                    menorz = originais[i].Z;
            }

            return new Vertice(maiorx - menorx, maiory - menory, maiorz - menorz);
        }

        public void translacao(double x, double y, double z) {
            double[,] mat = new double[4,4] { { 1, 0, 0, x },
                                              { 0, 1, 0, y },
                                              { 0, 0, 1, z },
                                              { 0, 0, 0, 1 } };

            acumulada = multMat(mat, acumulada, 4, 4, 4, 4);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 4; j++)
                    Console.Write(acumulada[i, j] + "\t");
            }
            aplicaAtuais();
        } 


    }

}
