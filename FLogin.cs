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
    public partial class FLogin : Form
    {
        private bool logued;
        private string[] argumentos;
        private string usuario;
        public delegate void TransfDelegado(string usuario);
        public TransfDelegado TrasfEvento;
        
        public FLogin(string[] args)
        {
            logued = false;
            InitializeComponent();
            argumentos = args;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario = TBusuario.Text;
            if (usuario != null && usuario != "")
            {
                this.TrasfEvento(usuario);
                this.Close();
            }
            else
                MessageBox.Show("Debe ingresar un usuario!");
        }

        private void TBusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
