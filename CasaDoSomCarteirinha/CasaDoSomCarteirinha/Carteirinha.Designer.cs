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
            this.salvar = new System.Windows.Forms.Button();
            this.imprimir = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.Label();
            this.indentidade = new System.Windows.Forms.Label();
            this.Curso = new System.Windows.Forms.Label();
            this.Mes = new System.Windows.Forms.Label();
            this.carteirinhabox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.carteirinhabox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(92, 453);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 1;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // imprimir
            // 
            this.imprimir.Location = new System.Drawing.Point(193, 453);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(75, 23);
            this.imprimir.TabIndex = 2;
            this.imprimir.Text = "Imprimir";
            this.imprimir.UseVisualStyleBackColor = true;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(157, 217);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(51, 20);
            this.nome.TabIndex = 3;
            this.nome.Text = "label1";
            // 
            // indentidade
            // 
            this.indentidade.AutoSize = true;
            this.indentidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.indentidade.Location = new System.Drawing.Point(106, 235);
            this.indentidade.Name = "indentidade";
            this.indentidade.Size = new System.Drawing.Size(51, 20);
            this.indentidade.TabIndex = 4;
            this.indentidade.Text = "label2";
            // 
            // Curso
            // 
            this.Curso.AutoSize = true;
            this.Curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Curso.Location = new System.Drawing.Point(311, 217);
            this.Curso.Name = "Curso";
            this.Curso.Size = new System.Drawing.Size(51, 20);
            this.Curso.TabIndex = 5;
            this.Curso.Text = "label2";
            // 
            // Mes
            // 
            this.Mes.AutoSize = true;
            this.Mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Mes.Location = new System.Drawing.Point(266, 217);
            this.Mes.Name = "Mes";
            this.Mes.Size = new System.Drawing.Size(39, 20);
            this.Mes.TabIndex = 6;
            this.Mes.Text = "Mes";
            // 
            // carteirinhabox
            // 
            this.carteirinhabox.BackColor = System.Drawing.Color.Transparent;
            this.carteirinhabox.Image = global::CasaDoSomCarteirinha.Properties.Resources.Carteira;
            this.carteirinhabox.InitialImage = global::CasaDoSomCarteirinha.Properties.Resources.Carteira;
            this.carteirinhabox.Location = new System.Drawing.Point(0, 0);
            this.carteirinhabox.Name = "carteirinhabox";
            this.carteirinhabox.Size = new System.Drawing.Size(399, 403);
            this.carteirinhabox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carteirinhabox.TabIndex = 0;
            this.carteirinhabox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.nome);
            this.panel1.Controls.Add(this.Curso);
            this.panel1.Controls.Add(this.indentidade);
            this.panel1.Controls.Add(this.Mes);
            this.panel1.Controls.Add(this.carteirinhabox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 406);
            this.panel1.TabIndex = 7;
            // 
            // Carteirinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(411, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Carteirinha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carteirinha";
            ((System.ComponentModel.ISupportInitialize)(this.carteirinhabox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox carteirinhabox;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button imprimir;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label indentidade;
        private System.Windows.Forms.Label Curso;
        private System.Windows.Forms.Label Mes;
        private System.Windows.Forms.Panel panel1;
    }
}