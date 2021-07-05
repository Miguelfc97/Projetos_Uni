using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_3
{
    public partial class FRMcontas : Form
    {
        public FRMcontas()
        {
            InitializeComponent();
        }

        private void calcular(object sander, EventArgs e)
    {
            int i1;
            int i2;
            int res;
            i1 = int.Parse(txtoper1.Text);
            i2 = int.Parse(txtoper2.Text);
            string botao;
            botao = ((Button)sander).Name;
            switch (botao)
            {
                case "btnsomar":
                    res = i1 + i2;
                    break;
                case "btnsub":
                    res = i1 - i2;
                    break;
                case "btnmult":
                    res = i1 * i2;
                    break;
                case "btndividir":
                    res = i1 / i2;
                    break;
                default:
                    res = 0;
                    break;
            }
            txtresultado.Text = res.ToString();
    }
    }
}
