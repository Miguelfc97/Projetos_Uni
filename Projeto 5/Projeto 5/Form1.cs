using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //int n;
            //n = int.Parse(txtfatorial.Text);
            int n = 0;
            if(!int.TryParse(txtfatorial.Text, out n))
            {
                MessageBox.Show("O valor de N nao é numerico");
                return;
            }
           //long ac = 1;
           // for (int i = n; i > 0; i--)
           //     ac = ac * i;
            long ac = fatorial(n);
            //int n2;
            //    n2 = n;
            //while (n >= 1)
            //{
            //    fatorial = fatorial * n;
            //    n--;
            //}
                
            lblresultado.Text = "O valor do fatorial de " + n.ToString() + " é: " + ac.ToString();
        }

        private void btnarranjos_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtfatorial.Text);
            int p = int.Parse(txtfatorial2.Text);
            if (!int.TryParse(txtfatorial.Text, out n))
            {
                MessageBox.Show("O valor de N nao é numerico");
                return;
            }
            if (!int.TryParse(txtfatorial.Text, out p))
            {
                MessageBox.Show("O valor de N nao é numerico");
                return;
            }
            long acn = 1;
            for (int i = n; i > 0; i--)
                acn = acn * i;

            long acp = 1;
            for (int i = (n - p); i > 0; i--)
                acp = acp * i;

            lblresultado.Text = (acn / acp).ToString();

        }

        private void btncombinacoes_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtfatorial.Text);
            int p = int.Parse(txtfatorial2.Text);
            if (!int.TryParse(txtfatorial.Text, out n))
            {
                MessageBox.Show("O valor de N nao é numerico");
                return;
            }
            if (!int.TryParse(txtfatorial.Text, out p))
            {
                MessageBox.Show("O valor de N nao é numerico");
                return;
            }
            long acn = 1;
            for (int i = n; i > 0; i--)
                acn = acn * i;

            long acp = 1;
            for (int i = (n - p); i > 0; i--)
                acp = acp * i;

            long acnp = 1;
            for (int i = p; i > 0; i--)
                acnp = acnp * i;
            lblresultado.Text = (acn / acnp / acp).ToString();
        }

        private void txtfatorial_Validating(object sender, CancelEventArgs e)
        {
            int n;
            TextBox tb = (TextBox) sender;
            if (string.IsNullOrEmpty(tb.Text))
                if (int.TryParse(tb.Text, out n))
                    if (n > 80 || n < 1)
                    {
                        MessageBox.Show("Valor fora do admissivel (1-80)");
                        e.Cancel = true;
                    }   
                    else
                        e.Cancel = false;
                else
                {
                 MessageBox.Show("Tem de introduzir um valor numerico");
                }
        }

        private long fatorial(int n)
        {
            long res = 1;
            for (int i = n; i > 0; i--)
                res = res * i;

            return res;
        }
    }
}
