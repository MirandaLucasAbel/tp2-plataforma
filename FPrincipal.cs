using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2
{
    public partial class FPrincipal : Form
    {

        FLogin hijoLogin;
        FUser hijoMain;
        internal string texto;
        string usuario;
        bool logued;
        public bool touched;

        public FPrincipal()
        {
            InitializeComponent();
            logued = false;
            hijoLogin = new FLogin (new string[1]);

           // hijoLogin.MdiParent = this;
            hijoLogin.TrasfEvento += TransfDelegado;

            hijoLogin.Show();
            touched = false;

        }

        private void TransfDelegado(string Usuario)
        {
            this.usuario = Usuario;
            int id = login(usuario, ""); //cambiar "" por paswwrod
            if (id!=-1)
            {
                MessageBox.Show("Log incorrecto, Usuario: " + usuario);
                hijoLogin.Close();
                hijoMain = new FUser(new string[] { usuario });
               // hijoMain.MdiParent = this;
                hijoMain.Show();
            }

        }

        private int login(string usuario, string password)
        {
            //hacer todas las comprobaciones
            if(usuario != null && usuario != "")
            {
                int id = 1;
                return id;
            }
            return -1;
        }
}
}