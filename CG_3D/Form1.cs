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
        Bitmap bmp;
        int largura;
        int altura;
        Objeto obj;
        int x = 0, y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            altura = pictureBox1.Height / 2;
            largura = pictureBox1.Width / 2;
            limpar();
        }


        private void bresenham(int x1, int y1, int x2, int y2, Color cor)
        {
            int declive = 1;
            int dx, dy, incE, incNE, d, x, y;
            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                if (x2 < x1) // x2 < x1
                    bresenham(x2, y2, x1, y1, cor);
                else
                {
                    if (y2 < y1)
                    {
                        dy = -dy;
                        declive = -1;
                    }

                    // Constante de Bresenham 
                    incE = 2 * dy;
                    incNE = 2 * dy - 2 * dx;
                    d = incE - dx;
                    y = y1;

                    for (x = x1; x <= x2; x++)
                    {

                        if (y2 < y1)
                        {
                            if (x + largura < pictureBox1.Width && y + altura < pictureBox1.Height && x + largura >= 0 && y + altura >= 0)
                                bmp.SetPixel(x + largura, y + altura, cor);
                        }
                        else
                            if (x + largura < pictureBox1.Width && y + altura < pictureBox1.Height && x + largura >= 0 && y + altura >= 0)
                                bmp.SetPixel(x + largura, y + altura, cor);
                        if (d <= 0)
                        {
                            d += incE;
                        }
                        else
                        {
                            d += incNE;
                            y += declive;
                        }
                    }
                }

            }
            else
            {
                if (y2 < y1) // x2 < x1
                    bresenham(x2, y2, x1, y1, cor);
                else
                {
                    if (x2 < x1)
                    {
                        dx = -dx;
                        declive = -1;
                    }

                    // Constante de Bresenham 
                    incE = 2 * dx;
                    incNE = 2 * dx - 2 * dy;
                    d = incE - dy;
                    x = x1;

                    for (y = y1; y <= y2; y++)
                    {
                        if (x + largura < pictureBox1.Width && y + altura < pictureBox1.Height && x + largura >= 0 && y + altura >= 0)
                            bmp.SetPixel(x + largura, y + altura, cor);
                        if (d <= 0)
                        {
                            d += incE;
                        }
                        else
                        {
                            d += incNE;
                            x += declive;
                        }
                    }
                }

            }

        }

        private void btCarrega_Click(object sender, EventArgs e)
        {
            limpar();

            obj = new Objeto();

            int i, j;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                List<string> arq = new List<string>();
                string str;

                while ((str = sr.ReadLine()) != null)
                    arq.Add(str);

                sr.Close();

                string[] aux = new string[4];
                for (i = 0; i < arq.Count; i++)
                {
                    aux = arq[i].Split();
                    if(aux[0].Equals("v"))
                    {
                        obj.Originais.Add(new Vertice(double.Parse(aux[1]), double.Parse(aux[2]), double.Parse(aux[3])));
                        obj.Atuais.Add(new Vertice(double.Parse(aux[1]), double.Parse(aux[2]), double.Parse(aux[3])));
                    }
                    else if (aux[0].Equals("f"))
                    {
                        Face f = new Face();
                        string pto = "";
                        int k;
                        for (k = 0; k < aux[1].Length && aux[1][k] != '/'; k++) {
                            pto += aux[1][k];
                        }
                        
                        f.Vertices.Add(obj.Originais[int.Parse(pto) - 1]);
                        pto = "";
                        for (k = 0; k < aux[2].Length && aux[2][k] != '/'; k++)
                        {
                            pto += aux[2][k];
                        }

                        f.Vertices.Add(obj.Originais[int.Parse(pto) - 1]);
                        pto = "";
                        for (k = 0; k < aux[3].Length && aux[3][k] != '/'; k++)
                        {
                            pto += aux[3][k];
                        }

                        f.Vertices.Add(obj.Originais[int.Parse(pto) - 1]);
                        obj.Faces.Add(f);

                    }
                }
                


                for(i = 0; i < obj.Faces.Count; i++)
                {
                    for(j = 0; j < obj.Faces[i].Vertices.Count - 1; j++)
                    {
                        bresenham((int)obj.Faces[i].Vertices[j].X, (int)obj.Faces[i].Vertices[j].Y, (int)obj.Faces[i].Vertices[j+1].X, (int)obj.Faces[i].Vertices[j+1].Y, Color.FromArgb(0,0,0));
                    }

                    bresenham((int)obj.Faces[i].Vertices[j].X, (int)obj.Faces[i].Vertices[j].Y, (int)obj.Faces[i].Vertices[0].X, (int)obj.Faces[i].Vertices[0].Y, Color.FromArgb(0, 0, 0));
                }

                pictureBox1.Image = bmp;
            }
        }

        private void limpar() {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            for (int x = 0; x < pictureBox1.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Height; y++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            }
            pictureBox1.Image = bmp;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btLateral_Click(object sender, EventArgs e)
        {
            limpar();
            int i, j;
            if (obj != null) {
                for (i = 0; i < obj.Faces.Count; i++)
                {
                    for (j = 0; j < obj.Faces[i].Vertices.Count - 1; j++)
                    {
                        bresenham((int)obj.Faces[i].Vertices[j].Z, (int)obj.Faces[i].Vertices[j].Y, (int)obj.Faces[i].Vertices[j + 1].Z, (int)obj.Faces[i].Vertices[j + 1].Y, Color.FromArgb(0, 0, 0));
                    }

                    bresenham((int)obj.Faces[i].Vertices[j].Z, (int)obj.Faces[i].Vertices[j].Y, (int)obj.Faces[i].Vertices[0].Z, (int)obj.Faces[i].Vertices[0].Y, Color.FromArgb(0, 0, 0));
                }

                pictureBox1.Image = bmp;
            }
        }

        private void btFrontal_Click(object sender, EventArgs e)
        {
            limpar();
            int i, j;
            if (obj != null)
            {
                for (i = 0; i < obj.Faces.Count; i++)
                {
                    for (j = 0; j < obj.Faces[i].Vertices.Count - 1; j++)
                    {
                        bresenham((int)obj.Faces[i].Vertices[j].X, (int)obj.Faces[i].Vertices[j].Y, (int)obj.Faces[i].Vertices[j + 1].X, (int)obj.Faces[i].Vertices[j + 1].Y, Color.FromArgb(0, 0, 0));
                    }

                    bresenham((int)obj.Faces[i].Vertices[j].X, (int)obj.Faces[i].Vertices[j].Y, (int)obj.Faces[i].Vertices[0].X, (int)obj.Faces[i].Vertices[0].Y, Color.FromArgb(0, 0, 0));
                }

                pictureBox1.Image = bmp;
            }
        }

        public void desenhaFrontal()
        {
            limpar();
            int i, j;
            if (obj != null)
            {
                for (i = 0; i < obj.Faces.Count; i++)
                {
                    for (j = 0; j < obj.Faces[i].Vertices.Count - 1; j++)
                    {
                        bresenham((int)obj.Faces[i].Vertices[j].X, (int)obj.Faces[i].Vertices[j].Y, (int)obj.Faces[i].Vertices[j + 1].X, (int)obj.Faces[i].Vertices[j + 1].Y, Color.FromArgb(0, 0, 0));
                    }

                    bresenham((int)obj.Faces[i].Vertices[j].X, (int)obj.Faces[i].Vertices[j].Y, (int)obj.Faces[i].Vertices[0].X, (int)obj.Faces[i].Vertices[0].Y, Color.FromArgb(0, 0, 0));
                }

                pictureBox1.Image = bmp;
            }
        }

        private void btSuperior_Click(object sender, EventArgs e)
        {
            limpar();
            int i, j;
            if (obj != null)
            {
                for (i = 0; i < obj.Faces.Count; i++)
                {
                    for (j = 0; j < obj.Faces[i].Vertices.Count - 1; j++)
                    {
                        bresenham((int)obj.Faces[i].Vertices[j].X, (int)obj.Faces[i].Vertices[j].Z, (int)obj.Faces[i].Vertices[j + 1].X, (int)obj.Faces[i].Vertices[j + 1].Z, Color.FromArgb(0, 0, 0));
                    }

                    bresenham((int)obj.Faces[i].Vertices[j].X, (int)obj.Faces[i].Vertices[j].Z, (int)obj.Faces[i].Vertices[0].X, (int)obj.Faces[i].Vertices[0].Z, Color.FromArgb(0, 0, 0));
                }

                pictureBox1.Image = bmp;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            /*
            int dx, dy;

            if (e.X < pictureBox1.Width && e.Y < pictureBox1.Height)
            {
                dx = x - e.X;
                dy = y - e.Y;

                if (Math.Abs(dx) > x || Math.Abs(dy) > y)
                {
                    if (rbTranslacao.Checked)
                        obj.translacao(e.X, e.Y, 0);

                    else if (rbEscala.Checked)
                        ; //Escala

                    else if (rbRotação.Checked)
                    {
                        if (dx != 0)
                            ;//Rotacao Y
                        if (dy != 0)
                            ;//Rotacao X
                    }

                    desenhaFrontal();
                    Console.WriteLine("Entrou");
                }
            }*/
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X < pictureBox1.Width && e.Y < pictureBox1.Height)
            {
                if (rbTranslacao.Checked)
                {
                    Vertice v = obj.encontraPtoMedio();
                    obj.translacao(-v.X, -v.Y, 0);
                    obj.translacao(e.X, e.Y, 0);

                    limpar();
                    desenhaFrontal();
                }
                
            }
        }
    }
}
