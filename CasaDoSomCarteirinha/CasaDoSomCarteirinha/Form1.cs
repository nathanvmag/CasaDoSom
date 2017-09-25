using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace CasaDoSomCarteirinha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nomebox.Text) && !string.IsNullOrEmpty(IdBox.Text) && !string.IsNullOrEmpty(cursoText.Text) &&
                !string.IsNullOrEmpty(mespicker.Text))
            {
                Carteirinha c = new Carteirinha(new string[4] { nomebox.Text, IdBox.Text, cursoText.Text, mespicker.Text });
                c.Visible = true;
            }
            else MessageBox.Show("Você deve preencher todos os campos", "Você deve preencher todos os campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
