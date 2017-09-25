using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

using System.Windows.Forms;

namespace CasaDoSomCarteirinha
{
   
  
    public partial class Carteirinha : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
         IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        string title;
        Font myFont;
        public Carteirinha(string[] Values)
        {
            InitializeComponent();
            Text = "Carteirinha de " + Values[0];
            title = Values[0];
            float dpiX, dpiY;
            Graphics graphics = this.CreateGraphics();
            dpiX = graphics.DpiX;
            dpiY = graphics.DpiY; 
             Console.WriteLine(dpiX + " " + dpiY);
            carteirinhabox.Size = new Size((int)(3.93701f * dpiX ), (int)(5.90551f * dpiY));
            imprimir.Location =new Point(imprimir.Location.X, carteirinhabox.Location.Y + carteirinhabox.Size.Height + 5);
            salvar.Location = new Point(salvar.Location.X, carteirinhabox.Location.Y + carteirinhabox.Size.Height + 5);

            byte[] fontData = Properties.Resources.Calisto;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Calisto.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Calisto.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], 12.0F);

            nome.Font = myFont;
            nome.Text = Values[0];
            nome.TextAlign = ContentAlignment.BottomLeft;
            nome.BackColor = Color.FromArgb(218, 234, 245);
            nome.ForeColor = Color.FromArgb(56, 57, 57);
            nome.Location = new Point((int)( carteirinhabox.Size.Width * 0.158f),(int)( carteirinhabox.Size.Height * 0.111f));
            
            
            indentidade.Font = myFont;
            indentidade.Text = Values[1];
            indentidade.TextAlign = ContentAlignment.BottomLeft;
            indentidade.BackColor = Color.FromArgb(218, 234, 245);
            indentidade.ForeColor = Color.FromArgb(56, 57, 57);
            indentidade.Location = new Point((int)(carteirinhabox.Size.Width * 0.24f), (int)(carteirinhabox.Size.Height * 0.16f));
          
            Curso.Font = myFont;
            Curso.Text = Values[2];
            Curso.TextAlign = ContentAlignment.BottomLeft;
            Curso.BackColor = Color.FromArgb(218, 234, 245);
            Curso.ForeColor = Color.FromArgb(56, 57, 57);
            Curso.Location = new Point((int)(carteirinhabox.Size.Width * 0.148f), (int)(carteirinhabox.Size.Height * 0.215f));
           
            Mes.Font = myFont;
            Mes.Text = Values[3];
            Mes.TextAlign = ContentAlignment.BottomLeft;
            Mes.BackColor = Color.FromArgb(218, 234, 245);
            Mes.ForeColor = Color.FromArgb(56, 57, 57);
            Mes.Location = new Point((int)(carteirinhabox.Size.Width * 0.218f), (int)(carteirinhabox.Size.Height * 0.2734f));
           
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "Carteira de "+ title+ ".png";
           
            saveFileDialog1.Filter = "Image File(*.png) | *.png";
            saveFileDialog1.DefaultExt = "png";
            saveFileDialog1.AddExtension = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {              
                             
                using (var Stream = saveFileDialog1.OpenFile())
                {
                    panel1.Controls.SetChildIndex(carteirinhabox, 0);
                    Bitmap bm = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height);
                    panel1.DrawToBitmap(bm, new Rectangle(0,0, panel1.ClientSize.Width, panel1.ClientSize.Height));
                    bm.Save(Stream,ImageFormat.Png);
                    panel1.Controls.SetChildIndex(carteirinhabox, 4);
                }

            }
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "Carteira de " + title + ".pdf";
            saveFileDialog1.Title = "Selecione o local para salvar e Imprimir";
            saveFileDialog1.Filter = "Image File(*.pdf) | *.pdf";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.AddExtension = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                using (var Stream = saveFileDialog1.OpenFile())
                {
                    panel1.Controls.SetChildIndex(carteirinhabox, 0);
                    Bitmap bm = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height);
                    panel1.DrawToBitmap(bm, new Rectangle(0, 0, panel1.ClientSize.Width, panel1.ClientSize.Height));
                    
                    bm.Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"temp.png"), ImageFormat.Png);
                    panel1.Controls.SetChildIndex(carteirinhabox, 4);

                    PdfDocument doc = new PdfDocument();
                    doc.Pages.Add(new PdfPage());
                    XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[0]);
                    XImage img = XImage.FromFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "temp.png"));

                    xgr.DrawImage(img, 20, 20);
                    doc.Save(Stream);
                    doc.Close();
                   
                }

            }
        }
    }
}
