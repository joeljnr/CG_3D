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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btCarrega = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btLateral = new System.Windows.Forms.Button();
            this.btFrontal = new System.Windows.Forms.Button();
            this.btSuperior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(972, 665);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btCarrega
            // 
            this.btCarrega.Location = new System.Drawing.Point(991, 13);
            this.btCarrega.Name = "btCarrega";
            this.btCarrega.Size = new System.Drawing.Size(154, 23);
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
            this.btLateral.Location = new System.Drawing.Point(1009, 67);
            this.btLateral.Name = "btLateral";
            this.btLateral.Size = new System.Drawing.Size(116, 23);
            this.btLateral.TabIndex = 4;
            this.btLateral.Text = "Projeção Lateral";
            this.btLateral.UseVisualStyleBackColor = true;
            this.btLateral.Click += new System.EventHandler(this.btLateral_Click);
            // 
            // btFrontal
            // 
            this.btFrontal.Location = new System.Drawing.Point(1009, 96);
            this.btFrontal.Name = "btFrontal";
            this.btFrontal.Size = new System.Drawing.Size(116, 23);
            this.btFrontal.TabIndex = 5;
            this.btFrontal.Text = "Projeção Frontal";
            this.btFrontal.UseVisualStyleBackColor = true;
            this.btFrontal.Click += new System.EventHandler(this.btFrontal_Click);
            // 
            // btSuperior
            // 
            this.btSuperior.Location = new System.Drawing.Point(1009, 125);
            this.btSuperior.Name = "btSuperior";
            this.btSuperior.Size = new System.Drawing.Size(116, 23);
            this.btSuperior.TabIndex = 6;
            this.btSuperior.Text = "Projeção Superior";
            this.btSuperior.UseVisualStyleBackColor = true;
            this.btSuperior.Click += new System.EventHandler(this.btSuperior_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 689);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btCarrega;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btLateral;
        private System.Windows.Forms.Button btFrontal;
        private System.Windows.Forms.Button btSuperior;
    }
}

