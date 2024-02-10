namespace Jogo_do_Labirinto
{
    partial class funcaoform
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
            this.btncima = new System.Windows.Forms.Button();
            this.btnesquerda = new System.Windows.Forms.Button();
            this.btnbaixo = new System.Windows.Forms.Button();
            this.btndireita = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncima
            // 
            this.btncima.BackColor = System.Drawing.Color.Aqua;
            this.btncima.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncima.Location = new System.Drawing.Point(479, 119);
            this.btncima.Name = "btncima";
            this.btncima.Size = new System.Drawing.Size(206, 126);
            this.btncima.TabIndex = 0;
            this.btncima.Text = "Cima";
            this.btncima.UseVisualStyleBackColor = false;
            this.btncima.Click += new System.EventHandler(this.btncima_Click);
            // 
            // btnesquerda
            // 
            this.btnesquerda.BackColor = System.Drawing.Color.Yellow;
            this.btnesquerda.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnesquerda.Location = new System.Drawing.Point(255, 269);
            this.btnesquerda.Name = "btnesquerda";
            this.btnesquerda.Size = new System.Drawing.Size(206, 126);
            this.btnesquerda.TabIndex = 1;
            this.btnesquerda.Text = "Esquerda";
            this.btnesquerda.UseVisualStyleBackColor = false;
            this.btnesquerda.Click += new System.EventHandler(this.btnesquerda_Click);
            // 
            // btnbaixo
            // 
            this.btnbaixo.BackColor = System.Drawing.Color.Lime;
            this.btnbaixo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbaixo.Location = new System.Drawing.Point(479, 417);
            this.btnbaixo.Name = "btnbaixo";
            this.btnbaixo.Size = new System.Drawing.Size(206, 126);
            this.btnbaixo.TabIndex = 2;
            this.btnbaixo.Text = "Baixo";
            this.btnbaixo.UseVisualStyleBackColor = false;
            this.btnbaixo.Click += new System.EventHandler(this.btnbaixo_Click);
            // 
            // btndireita
            // 
            this.btndireita.BackColor = System.Drawing.Color.Red;
            this.btndireita.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndireita.Location = new System.Drawing.Point(703, 269);
            this.btndireita.Name = "btndireita";
            this.btndireita.Size = new System.Drawing.Size(206, 126);
            this.btndireita.TabIndex = 3;
            this.btndireita.Text = "Direita";
            this.btndireita.UseVisualStyleBackColor = false;
            this.btndireita.Click += new System.EventHandler(this.btndireita_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Jogo_do_Labirinto.Properties.Resources.boneco;
            this.pictureBox2.Location = new System.Drawing.Point(-94, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = global::Jogo_do_Labirinto.Properties.Resources.boneco;
            this.pictureBox1.Location = new System.Drawing.Point(511, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // funcaoform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1146, 648);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btndireita);
            this.Controls.Add(this.btnbaixo);
            this.Controls.Add(this.btnesquerda);
            this.Controls.Add(this.btncima);
            this.Name = "funcaoform";
            this.Text = "funcaoform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncima;
        private System.Windows.Forms.Button btnesquerda;
        private System.Windows.Forms.Button btnbaixo;
        private System.Windows.Forms.Button btndireita;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}