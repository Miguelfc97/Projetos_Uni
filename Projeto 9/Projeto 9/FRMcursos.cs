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
    public partial class FRMcursos : Form
    {
        int i = 0;
        public curso[] a;

        public FRMcursos()
        {
            InitializeComponent();
        }

        void MostrarDados(curso cr)
        {
            txtcodigo.Text = cr.codigo.ToString();
            txtdescricao.Text = cr.descricao;
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                i = 0;
                MostrarDados(a[i]);
            }
            else
                MessageBox.Show("Não há cursos");
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
                MessageBox.Show("Não há cursos");
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
                txtcodigo.Text = a[i].codigo.ToString();
                txtdescricao.Text = a[i].descricao;
            }
            else
                MessageBox.Show("Não há cursos");
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Array.Resize<curso>(ref a, a.Length + 1);
            i = a.Length - 1;
            a[i].codigo = int.Parse(txtcodigo.Text);
            a[i].descricao = txtdescricao.Text;
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                a[i].codigo = int.Parse(txtcodigo.Text);
                a[i].descricao = txtdescricao.Text;
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                curso[] a2 = new curso[a.Length];
                a.CopyTo(a2, 0);
                a = new curso[a2.Length - 1];
                for (int j = 0; j < i; j++)
                    a[j] = a2[j];
                for (int j = i + 1; j < a2.Length; j++)
                    a[j - 1] = a2[j];
                if (i > a.Length - 1) i = a.Length - 1;
                if (a.Length > 0)
                {
                    txtcodigo.Text = a[i].codigo.ToString();
                    txtdescricao.Text = a[i].descricao;
                }
                else
                {
                    txtcodigo.Text = "";
                    txtdescricao.Text = "";
                }
            }
            else
                MessageBox.Show("Não há cursos");
        }

        private void ValidaCodigo(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            long i = 0;
            if (!long.TryParse(txt.Text, out i))
            {
                MessageBox.Show("Valor invalido");
                e.Cancel = true;
            }
        }

        private void FRMcursos_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            this.Close();
        }

        private void FRMcursos_Shown(object sender, EventArgs e)
        {
            a = ((FMRmenu)this.Owner).c;
        }

        private void FRMcursos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FMRmenu)this.Parent).c = a;
        }
    }
}
