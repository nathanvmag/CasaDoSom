using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDoSomCarteirinha
{
    public partial class Carteirinha : Form
    {
        public Carteirinha()
        {
            InitializeComponent();
            float dpiX, dpiY;
            Graphics graphics = this.CreateGraphics();
            dpiX = graphics.DpiX;
            dpiY = graphics.DpiY; 
             Console.WriteLine(dpiX + " " + dpiY);
            carteirinhabox.Size = new Size((int)(3.93701f * dpiX ), (int)(5.90551f * dpiY));
            imprimir.Location =new Point(imprimir.Location.X, carteirinhabox.Location.Y + carteirinhabox.Size.Height + 5);
            salvar.Location = new Point(salvar.Location.X, carteirinhabox.Location.Y + carteirinhabox.Size.Height + 5);
        }
    }
}
