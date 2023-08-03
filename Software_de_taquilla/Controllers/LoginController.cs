using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dao;
using Software_de_taquilla.Views;
using Software_de_taquilla.Views.AdminViews;
using Software_de_taquilla.Views.UserViews;

namespace Software_de_taquilla.Controllers
{
    public class LoginController
    {
        public Login view;
        public LoginController(Login view)
        {
            this.view = view;
            this.view.btn_login.Click += new EventHandler(this.buildView);
            this.view.label_reg.Click += new EventHandler(this.registerUser);
        }

        public void registerUser(Object sender, EventArgs e)
        {
            this.view.Visible = false;
            Register rg = new Register();
            rg.ShowDialog();
            this.view.Visible = true;
        }

        public void openByRole(int role)
        {
            if (role == 1)
            {
                this.view.printMessage("¡Bienvenido!");
                this.view.Visible = false;
                DashboardAdmin admin = new DashboardAdmin(role);
                admin.ShowDialog();
                this.view.Visible = true;
                return;
            }
            else if (role == 3)
            {
                this.view.printMessage("¡Bienvenido!");
                this.view.Visible = false;
                ListingView listing = new ListingView();
                listing.ShowDialog();
                this.view.Visible = true;
                return;
            }
        }

        private void buildView(Object sender, EventArgs e)
        {
            try
            {
                UserDao myuser = new UserDao();
                string user = this.view.txt_user.Text;
                string pass = this.view.txt_pass.Text;
                if (user.Equals("") || pass.Equals(""))
                {
                    MessageBox.Show("Debe llenar los campos antes de intentar loguearse");
                    return;
                }

                int rol = this.view.combo_role.SelectedIndex;
                if (myuser.userExist(user, pass, rol + 1))
                {
                    this.openByRole(rol + 1);
                }
                else
                {
                    this.view.printMessage("Usuario o Contraseña incorrectos");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al intentar autenticar al usuario: " +
               ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}

