using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dto;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace Software_de_taquilla.Views.UserViews.components
{
    public partial class MovieCard : UserControl
    {
        public Movie mov;
        public List<Object> objetos;
        public MovieCard(List<Object> objetos, Movie movie)
        {
            this.objetos = objetos;
            this.mov = movie;
            InitializeComponent();
            label1.Text = mov.name;
            //picture.Image = Image.FromFile("./../../../images/" + mov.image);
            this.loadImage("./../../../images/" + mov.image);
            int duracion = Convert.ToInt32(mov.duration);
            time_line.Value = duracion;
            label2.Text = duracion.ToString() + "min";
        }

        public void loadImage(string path)
        {
            Image image;
            FileStream myStream = new FileStream(path, FileMode.Open);
            try
            {
                image = Image.FromStream(myStream);
                picture.Image = image;
            }
            finally
            {
                myStream.Close();
                myStream.Dispose();
            }
        }





        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.SeaGreen;
            this.panel_card.BorderStyle = BorderStyle.FixedSingle;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.panel_card.BorderStyle = BorderStyle.None;
            label3.ForeColor = SystemColors.ControlDarkDark;

        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            this.objetos.Add(this.mov);
            MovieSelection mv = new MovieSelection(this.objetos);
            mv.ShowDialog();
            this.Visible = true;

        }
    }
}
