using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project10
{
    public partial class Form1 : Form
    {
        Cacho c;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncacho_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtn.Text))
                c = new Cacho(int.Parse(txtn.Text));
            lblcacho.Text = c.Listar();
        }

        private void btncomer_Click(object sender, EventArgs e)
        {
            c.Comer();
            lblcacho.Text = c.Listar();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            c.Envelhecer();
            lblcacho.Text = c.Listar();
        }
    }
}
