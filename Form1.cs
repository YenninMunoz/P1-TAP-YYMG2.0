using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_TAP_YYMG2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnred_Click(object sender, EventArgs e)
        {
            lblx.Text = "El botón es Rojo";
        }

        private void btnpink_Click(object sender, EventArgs e)
        {
            lblx.Text = "El botón es Rosa";
        }

        private void btnpurple_Click(object sender, EventArgs e)
        {
            lblx.Text = "El botón es Morado";
        }

        private void btnyellow_Click(object sender, EventArgs e)
        {
            lblx.Text = "El botón es Amarillo";
        }

        private void btngreen_Click(object sender, EventArgs e)
        {
            lblx.Text = "El botón es Verde";
        }

        private void btnazul_Click(object sender, EventArgs e)
        {
            lblx.Text = "El botón es Azul";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblx_Click(object sender, EventArgs e)
        {

        }

        private void btnsaludo_Click(object sender, EventArgs e)
        {
            lblx.Text = "Saludos!";
        }
    }
}
