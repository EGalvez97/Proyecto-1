using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Certificado : Form
    {
        public Certificado()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void txtCurp_TextChanged(object sender, EventArgs e)
        {
            if(txtCurp.Text == "MECL000709HSLNHSA6")
            {
                txtNombre.Text = "LUIS EMMANUEL";
                txtApellido.Text = "MENDOZA CHAVARIN";
                txtPromedio.Text = "7.61";
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printCertificado = new PrintDocument();
            PrinterSettings ps= new PrinterSettings();
            printCertificado.PrinterSettings = ps;
            printCertificado.PrintPage += Imprimir;
            printCertificado.Print();

        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Verdana", 30, FontStyle.Regular, GraphicsUnit.Point);
            Font font2=new Font("Verdana",16,FontStyle.Regular, GraphicsUnit.Point);

            int y = 20;
         
            e.Graphics.DrawString("SISTEMA EDUCATIVO NACIONAL",font,Brushes.Black,new RectangleF(150,y+=40,600,40));
            e.Graphics.DrawString("-Secretaria de Educacion Publica y Cultura del Estado de Sinaloa",font2,Brushes.Black,new RectangleF(0, y += 60, 900, 40));
        
        
        }
        
    }
}
