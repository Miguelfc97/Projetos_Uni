using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9
{

    public partial class frmAlunos : Form
    {
        int i = 0;
        public Aluno[] a;

        public frmAlunos()
        {
            InitializeComponent();
        }

        void MostraDados(Aluno al)
        {
            txtNumero.Text = al.numero.ToString();
            txtNome.Text = al.nome;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
                MostraDados(a[i = 0]);
            else
                MessageBox.Show("Tem de ter pelo menos um aluno");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
                if (i > 0)
                    MostraDados(a[--i]);
                else
                    MessageBox.Show("Não pode passar para trás do primeiro");
            else
                MessageBox.Show("Tem de ter pelo menos um aluno");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
                if (i < a.Length - 1)
                    MostraDados(a[++i]);
                else
                    MessageBox.Show("Não pode passar para lá do último");
            else
                MessageBox.Show("Tem de ter pelo menos um aluno");
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
                MostraDados(a[i = a.Length - 1]);
            else
                MessageBox.Show("Tem de ter pelo menos um aluno");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("Tem de preencher todos os campos");
                return;
            }

            Array.Resize<Aluno>(ref a, a.Length + 1);
            a[i = a.Length - 1] = new Aluno()
            {
                numero = int.Parse(txtNumero.Text),
                nome = txtNome.Text
            };
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("Tem de preencher todos os campos");
                return;
            }

            if (a.Length > 0)
                a[i] = new Aluno()
                {
                    numero = int.Parse(txtNumero.Text),
                    nome = txtNome.Text
                };
            else
                MessageBox.Show("Tem de ter pelo menos um aluno");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                Aluno[] al2 = new Aluno[a.Length];
                a.CopyTo(al2, 0);
                a = new Aluno[al2.Length - 1];
                for (int j = 0; j < i; j++)
                    a[j] = al2[j];
                for (int j = i + 1; j < al2.Length; j++)
                    a[j - 1] = al2[j];
                i = (i > a.Length - 1) ? a.Length - 1 : i;
                if (a.Length > 0)
                    MostraDados(a[i]);
                else
                {
                    txtNumero.Text = "";
                    txtNome.Text = "";
                }

            }
            else
                MessageBox.Show("Tem de ter pelo menos um aluno");
        }

        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumero.Text))
            {
                int j = 0;
                if (!int.TryParse(txtNumero.Text, out j))
                {
                    e.Cancel = true;
                    MessageBox.Show("Tem de introduzir um número válido");
                }
            }

        }

        private void frmAlunos_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenu f = (frmMenu)this.Owner;
            f.a = this.a;
        }
    }
}
