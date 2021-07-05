using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_7
{
    struct peca
    {
        public int nordem;
        public string descricao;
        public DateTime datacompra;
    }

    public partial class fmrmuseu : Form
    {
        private int i = 0;
        private peca[] a = new peca[] { };

        private void MostrarDados(peca p)
        {
            txtordem.Text = p.nordem.ToString();
            txtdescricao.Text = p.descricao;
            dtpdata.Value = p.datacompra;
        }


        public fmrmuseu()
        {
            InitializeComponent();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                i = 0;
                MostrarDados(a[i]);
            }
            else
                MessageBox.Show("Não há peças");
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
                if (i > 0)
                {
                    i--;
                    MostrarDados(a[i]);
                }
                else
                    MessageBox.Show("Não pode passar do primeiro");
            else
                MessageBox.Show("Não há peças");
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
                if (i < a.Length - 1)
                {
                    i++;
                    MostrarDados(a[i]);
                }
                else
                    MessageBox.Show("Não pode passar do ultimo");
            else
                MessageBox.Show("Não há peças");
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                i = a.Length - 1;
                txtordem.Text = a[i].nordem.ToString();
                txtdescricao.Text = a[i].descricao;
                dtpdata.Value = a[i].datacompra;
            }
            else
                MessageBox.Show("Não há peças");
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Array.Resize<peca>(ref a, a.Length + 1);
            i = a.Length - 1;
            a[i].nordem = int.Parse(txtordem.Text);
            a[i].descricao = txtdescricao.Text;
            a[i].datacompra = dtpdata.Value;
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                a[i].nordem = int.Parse(txtordem.Text);
                a[i].descricao = txtdescricao.Text;
                a[i].datacompra = dtpdata.Value;
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                peca[] a2 = new peca[a.Length];
                a.CopyTo(a2, 0);
                a = new peca[a2.Length - 1];
                for (int j = 0; j < i; j++)
                    a[j] = a2[j];
                for (int j = i + 1; j < a2.Length; j++)
                    a[j - 1] = a2[j];
                if (i > a.Length - 1) i = a.Length - 1;
                if (a.Length > 0)
                {
                    txtordem.Text = a[i].nordem.ToString();
                    txtdescricao.Text = a[i].descricao;
                    dtpdata.Value = a[i].datacompra;
                }
                else
                {
                    txtordem.Text = "";
                    txtdescricao.Text = "";
                    dtpdata.Value = DateTime.Today;
                }
            }
            else
                MessageBox.Show("Não há peças");
        }

        private void ValidaNumero(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            long i = 0;
            if (!long.TryParse(txt.Text, out i))
            {
                MessageBox.Show("Valor invalido");
                e.Cancel = true;
            }
        }
    }
}
