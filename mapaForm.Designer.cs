namespace Jogo_do_Labirinto
{
    partial class mapaForm
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
            this.btncomecar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncomecar
            // 
            this.btncomecar.BackColor = System.Drawing.Color.Blue;
            this.btncomecar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomecar.Location = new System.Drawing.Point(372, 159);
            this.btncomecar.Name = "btncomecar";
            this.btncomecar.Size = new System.Drawing.Size(540, 347);
            this.btncomecar.TabIndex = 0;
            this.btncomecar.Text = "Começar";
            this.btncomecar.UseVisualStyleBackColor = false;
            this.btncomecar.Click += new System.EventHandler(this.btncomecar_Click);
            // 
            // mapaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1307, 652);
            this.Controls.Add(this.btncomecar);
            this.Name = "mapaForm";
            this.Text = "mapaForm";
            this.Load += new System.EventHandler(this.mapaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncomecar;
    }
}