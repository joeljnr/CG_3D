using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_3D
{
    public partial class Form1 : Form
    {
        List<Objeto> objs = new List<Objeto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btCarrega_Click(object sender, EventArgs e)
        {
            Objeto obj = new Objeto();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                List<string> arq = new List<string>();
                string str;

                while ((str = sr.ReadLine()) != null)
                    arq.Add(str);

                sr.Close();

                string[] aux = new string[4];
                for (int i = 0; i < arq.Count; i++)
                {
                    aux = arq[i].Split();
                    if(aux[0].Equals("v"))
                    {
                        obj.Originais.Add(new Vertice(double.Parse(aux[1]), double.Parse(aux[2]), double.Parse(aux[3])));
                    }
                    else if (aux[0].Equals("f"))
                    {
                        Face f = new Face();
                        //charAt
                        f.Vertices.Add(obj.Originais[int.Parse(aux[1][0].ToString())]);
                        f.Vertices.Add(obj.Originais[int.Parse(aux[2][0].ToString())]);
                        f.Vertices.Add(obj.Originais[int.Parse(aux[3][0].ToString())]);
                        obj.Faces.Add(f);
                    }
                }
            }

            for (int i = 0; i < obj.Originais.Count; i++)
                Console.Write(obj.Originais.ToString());
        }
    }
}
