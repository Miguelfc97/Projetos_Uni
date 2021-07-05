using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_9
{
    public partial class FMRalunos : Form
    {
        int i = 0;
        public alunos[] a;

        public FMRalunos()
        {
            InitializeComponent();
        }

        void MostrarDados(alunos al)
        {
            txtnumero.Text = al.numero.ToString();
            txtnome.Text = al.nome;
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                i = 0;
                MostrarDados(a[i]);
            }
            else
                MessageBox.Show("Não há alunos");
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
                MessageBox.Show("Não há alunos");
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
                MessageBox.Show("Não há cursos");
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                i = a.Length - 1;
                txtnumero.Text = a[i].numero.ToString();
                txtnome.Text = a[i].nome;
            }
            else
                MessageBox.Show("Não há alunos");
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Array.Resize<alunos>(ref a, a.Length + 1);
            i = a.Length - 1;
            a[i].numero = int.Parse(txtnumero.Text);
            a[i].nome = txtnome.Text;
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                a[i].numero = int.Parse(txtnumero.Text);
                a[i].nome = txtnome.Text;
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                alunos[] a2 = new alunos[a.Length];
                a.CopyTo(a2, 0);
                a = new alunos[a2.Length - 1];
                for (int j = 0; j < i; j++)
                    a[j] = a2[j];
                for (int j = i + 1; j < a2.Length; j++)
                    a[j - 1] = a2[j];
                if (i > a.Length - 1) i = a.Length - 1;
                if (a.Length > 0)
                {
                    txtnumero.Text = a[i].numero.ToString();
                    txtnome.Text = a[i].nome;
                }
                else
                {
                    txtnumero.Text = "";
                    txtnome.Text = "";
                }
            }
            else
                MessageBox.Show("Não há alunos");
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

        private void FMRalunos_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            this.Close();
        }

        private void FMRalunos_Shown(object sender, EventArgs e)
        {
            a = ((FMRmenu)this.Owner).a;
        }

        private void FMRalunos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FMRmenu)this.Parent).a = a;
        }
    }
}
