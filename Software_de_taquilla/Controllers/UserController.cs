using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dao;
using Software_de_taquilla.Views;

namespace Software_de_taquilla.Controllers
{
    public class UserController
    {
        public Login view;
        public UserController(Login view)
        {
            this.view = view;
            this.view.btn_login.Click += new EventHandler(this.buildView);
        }
        //Agregue esto

        private void buildView(Object sender, EventArgs e)
        {
            UserDao myuser = new UserDao();
            string msg = myuser.isConnected() ? "Conexion realizaada" : "Error en al conexion";
            this.view.printMessage(msg);
        }
    }
}

