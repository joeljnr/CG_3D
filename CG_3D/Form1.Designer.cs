namespace CG_3D
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btCarrega = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btLateral = new System.Windows.Forms.Button();
            this.btFrontal = new System.Windows.Forms.Button();
            this.btSuperior = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbTranslacao = new System.Windows.Forms.RadioButton();
            this.rbEscala = new System.Windows.Forms.RadioButton();
            this.rbRotação = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(949, 665);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btCarrega
            // 
            this.btCarrega.Location = new System.Drawing.Point(967, 13);
            this.btCarrega.Name = "btCarrega";
            this.btCarrega.Size = new System.Drawing.Size(178, 23);
            this.btCarrega.TabIndex = 2;
            this.btCarrega.Text = "Carrega .obj";
            this.btCarrega.UseVisualStyleBackColor = true;
            this.btCarrega.Click += new System.EventHandler(this.btCarrega_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(991, 654);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(146, 23);
            this.btLimpar.TabIndex = 3;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btLateral
            // 
            this.btLateral.Image = ((System.Drawing.Image)(resources.GetObject("btLateral.Image")));
            this.btLateral.Location = new System.Drawing.Point(1027, 42);
            this.btLateral.Name = "btLateral";
            this.btLateral.Size = new System.Drawing.Size(55, 55);
            this.btLateral.TabIndex = 4;
            this.btLateral.UseVisualStyleBackColor = true;
            this.btLateral.Click += new System.EventHandler(this.btLateral_Click);
            // 
            // btFrontal
            // 
            this.btFrontal.Image = ((System.Drawing.Image)(resources.GetObject("btFrontal.Image")));
            this.btFrontal.Location = new System.Drawing.Point(966, 42);
            this.btFrontal.Name = "btFrontal";
            this.btFrontal.Size = new System.Drawing.Size(55, 55);
            this.btFrontal.TabIndex = 5;
            this.btFrontal.UseVisualStyleBackColor = true;
            this.btFrontal.Click += new System.EventHandler(this.btFrontal_Click);
            // 
            // btSuperior
            // 
            this.btSuperior.Image = ((System.Drawing.Image)(resources.GetObject("btSuperior.Image")));
            this.btSuperior.Location = new System.Drawing.Point(1088, 42);
            this.btSuperior.Name = "btSuperior";
            this.btSuperior.Size = new System.Drawing.Size(55, 55);
            this.btSuperior.TabIndex = 6;
            this.btSuperior.UseVisualStyleBackColor = true;
            this.btSuperior.Click += new System.EventHandler(this.btSuperior_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(968, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Transformações:";
            // 
            // rbTranslacao
            // 
            this.rbTranslacao.AutoSize = true;
            this.rbTranslacao.Location = new System.Drawing.Point(971, 130);
            this.rbTranslacao.Name = "rbTranslacao";
            this.rbTranslacao.Size = new System.Drawing.Size(78, 17);
            this.rbTranslacao.TabIndex = 9;
            this.rbTranslacao.TabStop = true;
            this.rbTranslacao.Text = "Translação";
            this.rbTranslacao.UseVisualStyleBackColor = true;
            // 
            // rbEscala
            // 
            this.rbEscala.AutoSize = true;
            this.rbEscala.Location = new System.Drawing.Point(971, 154);
            this.rbEscala.Name = "rbEscala";
            this.rbEscala.Size = new System.Drawing.Size(57, 17);
            this.rbEscala.TabIndex = 10;
            this.rbEscala.TabStop = true;
            this.rbEscala.Text = "Escala";
            this.rbEscala.UseVisualStyleBackColor = true;
            // 
            // rbRotação
            // 
            this.rbRotação.AutoSize = true;
            this.rbRotação.Location = new System.Drawing.Point(971, 178);
            this.rbRotação.Name = "rbRotação";
            this.rbRotação.Size = new System.Drawing.Size(66, 17);
            this.rbRotação.TabIndex = 11;
            this.rbRotação.TabStop = true;
            this.rbRotação.Text = "Rotação";
            this.rbRotação.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 689);
            this.Controls.Add(this.rbRotação);
            this.Controls.Add(this.rbEscala);
            this.Controls.Add(this.rbTranslacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSuperior);
            this.Controls.Add(this.btFrontal);
            this.Controls.Add(this.btLateral);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCarrega);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btCarrega;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btLateral;
        private System.Windows.Forms.Button btFrontal;
        private System.Windows.Forms.Button btSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbTranslacao;
        private System.Windows.Forms.RadioButton rbEscala;
        private System.Windows.Forms.RadioButton rbRotação;
    }
}

