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
        List<Vertice> vertices;
        List<Face> faces;

        public Form1()
        {
            InitializeComponent();
        }

        private void btCarrega_Click(object sender, EventArgs e)
        {
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

                    }
                    else if(aux[0].Equals("vn"))
                    {

                    }
                    else if (aux[0].Equals("f"))
                    {

                    }
                }
            }
        }
    }
}
