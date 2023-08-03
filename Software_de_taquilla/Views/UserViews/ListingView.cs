using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_de_taquilla.Controllers;

namespace Software_de_taquilla.Views.UserViews
{
    public partial class ListingView : Form
    {
        public ListingView()
        {
            InitializeComponent();
            ListingController controller = new ListingController(this);
        }

        public void printMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
