using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_de_taquilla.Models.Dao;
using Software_de_taquilla.Models.Dto;

namespace Software_de_taquilla.Views.UserViews
{
    public partial class Asientos : Form
    {
        public Movie movie;
        public int cantidad;
        public int contador;
        public double monto;
        public List<Object> objetos;
        public List<int> id_asientos = new List<int>();
        public Asientos(List<Object> objetos)
        {
            this.objetos = objetos;
            this.monto = (double)objetos[4];
            this.contador = 0;
            this.cantidad = (int)objetos[3];
            this.movie = (Movie?)objetos[2];
            InitializeComponent();
            this.createEffects();
            txt_asientos.Text = this.cantidad.ToString();
            this.fillData();
        }


        public void fillData()
        {
            AsientoDao asdao = new AsientoDao();
            List<Asiento> asientos = asdao.getAsiento();
            foreach (Control button in panel2.Controls)
            {
                if (button is Button)
                {
                    foreach (Asiento asi in asientos)
                    {
                        string name = button.Name;
                        int pos = name.IndexOf('_');
                        int num = getNum(name[pos + 1]);
                        string asiento = name.Substring(pos + 2);
                        if (asi.numero.Equals(Convert.ToInt32(num + asiento)))
                        {
                            if (asi.estado == 1)
                            {
                                button.BackColor = Color.Red;
                                button.Enabled = false;
                            }
                            else
                            {
                                button.BackColor = Color.WhiteSmoke;
                            }
                            break;
                        }
                    }
                }
            }

        }

        public void clickEvent(object sender, EventArgs e)
        {
            bool done = false;
            if (this.contador >= this.cantidad) done = true;
            Button btn = (Button)sender;
            if (btn.BackColor == System.Drawing.Color.Red) return;
            if (btn.BackColor == System.Drawing.Color.WhiteSmoke)
            {
                if (done) return;
                btn.BackColor = System.Drawing.Color.Green;
                this.contador++;
            }
            else
            {
                btn.BackColor = System.Drawing.Color.WhiteSmoke;
                this.contador--;
            }
        }
        public void createEffects()
        {
            foreach (Control button in panel2.Controls)
            {
                if (button is Button)
                {
                    button.Click += new EventHandler(this.clickEvent);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AsientoDao asi = new AsientoDao();
            asi.updateAsiento(this.movie.id_room, 1);
        }
        public int getNum(char letter)
        {
            if (letter.Equals('a')) return 0;
            if (letter.Equals('b')) return 1;
            if (letter.Equals('c')) return 2;
            if (letter.Equals('d')) return 3;
            if (letter.Equals('e')) return 4;
            else return 5;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            AsientoDao asidao = new AsientoDao();
            foreach (Control button in panel2.Controls)
            {
                if (button is Button)
                {
                    if (button.BackColor == System.Drawing.Color.Green)
                    {
                        string name = button.Name;
                        int pos = name.IndexOf('_');
                        int num = getNum(name[pos + 1]);
                        string asiento = name.Substring(pos + 2);
                        int id = Convert.ToInt32(num.ToString() + asiento);
                        asidao.updateAsiento(id, 1);
                        id_asientos.Add(id);
                    }
                }
            }
            MessageBox.Show("Asientos reserados temporalmente");
            Pagos pagosForm = new Pagos(objetos, id_asientos);
            pagosForm.FormClosed += new FormClosedEventHandler(this.FormClosed);
            this.Visible = false;
            pagosForm.ShowDialog();
        }


        public void FormClosed(Object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
