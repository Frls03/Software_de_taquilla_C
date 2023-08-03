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

namespace Software_de_taquilla.Views.UserViews
{
    public partial class SeleccionBoletos : Form
    {
        public Movie movie;
        public List<Object> objetos;
        public SeleccionBoletos(List<Object> objetos)
        {
            this.objetos = objetos;
            this.movie = (Movie?)this.objetos[2];
            InitializeComponent();
        }

        private void btna_1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_n1.Text) + 1;
            txt_n1.Text = n.ToString();
        }

        private void btna_2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_n1.Text) - 1;
            if (n >= 0) txt_n1.Text = n.ToString();
        }

        private void btnn_1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_n2.Text) + 1;
            txt_n2.Text = n.ToString();

        }

        private void btnn_2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_n2.Text) - 1;
            if (n >= 0) txt_n2.Text = n.ToString();
        }

        private void btn_e1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_n3.Text) + 1;
            txt_n3.Text = n.ToString();
        }

        private void btn_e2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_n3.Text) - 1;
            if (n >= 0) txt_n3.Text = n.ToString();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txt_n1.Text) + Convert.ToInt32(txt_n2.Text) + Convert.ToInt32(txt_n3.Text);
            double monto = Convert.ToInt32(txt_n1.Text) * 46 + Convert.ToInt32(txt_n2.Text) * 39 + Convert.ToInt32(txt_n3.Text) * 39;

            //Asientos asi = new Asientos(movie, cantidad, monto);
            this.objetos.Add(cantidad);
            this.objetos.Add(monto);
            this.objetos.Add(Convert.ToInt32(txt_n1.Text));
            this.objetos.Add(Convert.ToInt32(txt_n2.Text));
            this.objetos.Add(Convert.ToInt32(txt_n3.Text));
            Asientos asi = new Asientos(this.objetos);
            asi.FormClosing += new FormClosingEventHandler(this.FClosed);
            this.Visible = false;
            asi.ShowDialog();
        }

        public void FClosed(Object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

    }
}
