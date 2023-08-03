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
using Software_de_taquilla.Models.Dao;

namespace Software_de_taquilla.Views.UserViews
{
    public partial class MovieSelection : Form
    {
        public Movie movie;
        public List<Object> objetos;
        public MovieSelection(List<Object> objetos)
        {
            this.objetos = objetos;
            this.movie = (Movie?)this.objetos[2];
            InitializeComponent();
            this.buildComponent();
        }

        public void buildComponent()
        {
            lbl_1.Text = this.movie.name;
            lbl_2.Text = this.movie.public_;
            lbl_3.Text = this.movie.duration;
            lbl_4.Text = this.movie.id_room.ToString();
            pic_imag.Image = Image.FromFile("./../../../images/" + movie.image);
            this.fillSchedules();
        }

        public void ClickEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string id = btn.Name.Replace("btN_", "");
            SeleccionBoletos sb = new SeleccionBoletos(this.objetos);
            sb.FormClosed += new FormClosedEventHandler(this.fclosed);
            this.Visible = false;
            sb.ShowDialog();
        }

        public void fclosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        public void fillSchedules()
        {
            ScheduleDao dao = new ScheduleDao();
            List<Schedule> sc = dao.getSchedules();
            foreach (Schedule sh in sc)
            {
                Button btn = new Button();
                btn.Text = sh.h_start;
                btn.Name = "btN_" + sh.id.ToString();
                btn.Click += new EventHandler(this.ClickEvent);
                this.panel_horarios.Controls.Add(btn);
            }
        }
    }
}
