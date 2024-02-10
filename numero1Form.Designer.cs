namespace Jogo_do_Labirinto
{
    partial class numero1Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.btndireita = new System.Windows.Forms.Button();
            this.btnbaixo = new System.Windows.Forms.Button();
            this.btnesquerda = new System.Windows.Forms.Button();
            this.btncima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 166);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // btndireita
            // 
            this.btndireita.BackColor = System.Drawing.Color.Red;
            this.btndireita.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndireita.Location = new System.Drawing.Point(521, 163);
            this.btndireita.Name = "btndireita";
            this.btndireita.Size = new System.Drawing.Size(206, 126);
            this.btndireita.TabIndex = 10;
            this.btndireita.Text = "Direita";
            this.btndireita.UseVisualStyleBackColor = false;
            this.btndireita.Click += new System.EventHandler(this.btndireita_Click);
            // 
            // btnbaixo
            // 
            this.btnbaixo.BackColor = System.Drawing.Color.Lime;
            this.btnbaixo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbaixo.Location = new System.Drawing.Point(297, 311);
            this.btnbaixo.Name = "btnbaixo";
            this.btnbaixo.Size = new System.Drawing.Size(206, 126);
            this.btnbaixo.TabIndex = 9;
            this.btnbaixo.Text = "Baixo";
            this.btnbaixo.UseVisualStyleBackColor = false;
            this.btnbaixo.Click += new System.EventHandler(this.btnbaixo_Click);
            // 
            // btnesquerda
            // 
            this.btnesquerda.BackColor = System.Drawing.Color.Yellow;
            this.btnesquerda.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnesquerda.Location = new System.Drawing.Point(73, 163);
            this.btnesquerda.Name = "btnesquerda";
            this.btnesquerda.Size = new System.Drawing.Size(206, 126);
            this.btnesquerda.TabIndex = 8;
            this.btnesquerda.Text = "Esquerda";
            this.btnesquerda.UseVisualStyleBackColor = false;
            this.btnesquerda.Click += new System.EventHandler(this.btnesquerda_Click);
            // 
            // btncima
            // 
            this.btncima.BackColor = System.Drawing.Color.Aqua;
            this.btncima.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncima.Location = new System.Drawing.Point(297, 13);
            this.btncima.Name = "btncima";
            this.btncima.Size = new System.Drawing.Size(206, 126);
            this.btncima.TabIndex = 7;
            this.btncima.Text = "Cima";
            this.btncima.UseVisualStyleBackColor = false;
            this.btncima.Click += new System.EventHandler(this.btncima_Click);
            // 
            // numero1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndireita);
            this.Controls.Add(this.btnbaixo);
            this.Controls.Add(this.btnesquerda);
            this.Controls.Add(this.btncima);
            this.Controls.Add(this.label1);
            this.Name = "numero1Form";
            this.Text = "numero1Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndireita;
        private System.Windows.Forms.Button btnbaixo;
        private System.Windows.Forms.Button btnesquerda;
        private System.Windows.Forms.Button btncima;
    }
}