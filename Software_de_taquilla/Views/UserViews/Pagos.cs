using Software_de_taquilla.Models.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_de_taquilla.Models.Dto;
using Software_de_taquilla.Helpers;


using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using MySqlX.XDevAPI.Relational;

namespace Software_de_taquilla.Views.UserViews
{
    public partial class Pagos : Form
    {
        public double monto;
        public List<int> asientos;
        public List<Object> objetos;
        public Pagos(List<Object> objetos, List<int> asi)
        {
            this.objetos = objetos;
            this.asientos = asi;
            this.monto = (double)objetos[4];
            InitializeComponent();
            txt_monto.Text = this.monto.ToString();

        }

        private void btn_cobro_Click(object sender, EventArgs e)
        {
            VentaDao vd = new VentaDao();
            BoletoDao bd = new BoletoDao();
            vd.insertVenta((double)this.objetos[4], (int)this.objetos[1]);
            int lastId = vd.getlastID();
            int contador = 0;
            string filas = string.Empty;
            for (int i = 5; i < 8; i++)
            {

                int cant_boletos = (int)this.objetos[i];
                if (cant_boletos == 0) continue;
                string clas = "Ninguna";
                double precio = 39;
                if (i == 5) { clas = "Adulto"; precio = 46; }
                if (i == 6) clas = "Niños"; ;
                if (i == 7) clas = "Tercera Edad";
                filas += "<tr>";
                filas += "<td>" + cant_boletos.ToString() + "</td>";
                filas += "<td>" + clas + "</td>";
                filas += "<td>" + precio.ToString() + "</td>";
                filas += "<td>" + (precio * cant_boletos).ToString() + "</td>";
                filas += "</tr>";
                for (int j = 0; j < cant_boletos; j++)
                {
                    Movie mov = (Movie?)this.objetos[2];
                    int id_cine = (int)this.objetos[1];
                    bd.insertBoleto(lastId, mov.id, id_cine, this.asientos[contador], precio, clas);
                    contador++;
                }
            }
            PdfBuilder.createInvoice(txt_correo.Text, lastId.ToString(), this.monto.ToString(), filas);
            MessageBox.Show("Pago realizado, factura enviada a su correo");
            this.Close();
        }



    }
}
