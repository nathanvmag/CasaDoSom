namespace CasaDoSomCarteirinha
{
    partial class Carteirinha
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
            this.carteirinhabox = new System.Windows.Forms.PictureBox();
            this.salvar = new System.Windows.Forms.Button();
            this.imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carteirinhabox)).BeginInit();
            this.SuspendLayout();
            // 
            // carteirinhabox
            // 
            this.carteirinhabox.Image = global::CasaDoSomCarteirinha.Properties.Resources.Carteira;
            this.carteirinhabox.InitialImage = global::CasaDoSomCarteirinha.Properties.Resources.Carteira;
            this.carteirinhabox.Location = new System.Drawing.Point(0, 0);
            this.carteirinhabox.Name = "carteirinhabox";
            this.carteirinhabox.Size = new System.Drawing.Size(375, 426);
            this.carteirinhabox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carteirinhabox.TabIndex = 0;
            this.carteirinhabox.TabStop = false;
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(92, 453);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 1;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            // 
            // imprimir
            // 
            this.imprimir.Location = new System.Drawing.Point(193, 453);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(75, 23);
            this.imprimir.TabIndex = 2;
            this.imprimir.Text = "Imprimir";
            this.imprimir.UseVisualStyleBackColor = true;
            // 
            // Carteirinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(387, 488);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.carteirinhabox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Carteirinha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carteirinha";
            ((System.ComponentModel.ISupportInitialize)(this.carteirinhabox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox carteirinhabox;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button imprimir;
    }
}