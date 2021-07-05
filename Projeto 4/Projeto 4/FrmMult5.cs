using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_4
{
    public partial class FrmMult5 : Form
    {
        public FrmMult5()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, mult;
            mult = int.Parse(txtmult.Text);
            n1 = int.Parse(txtliminf.Text);
            n2 = int.Parse(txtlimsup.Text);
            n3 = (n2 - n1) / mult;
            if ((n3 % mult) == 0)
                n3--;
            if ((n1 % mult) == 0)
                n3++;
            if ((n2 % mult) == 0)
                n3++;
            //n3=0;
            //for (int i = n1; i <= n2; i++)
            //    if ((i % mult) == 0)
            //        n3++; 

            lblresultado.Text = "O numero de multiplos de " + mult.ToString() + " entre " + n1.ToString() + " e " + n2.ToString() + " é: " + n3.ToString();
        }
    }
}
