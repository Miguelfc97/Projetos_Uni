using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto6
{
    struct Aluno
    {
        public long numero;
        public string nome;
        public int nota;
    }

    public partial class fmrAlunos : Form
    {
        private int i = 0;
        private Aluno[] a = new Aluno[] { };

        private void MostrarDados(Aluno al)
        {
            txtnum.Text = al.numero.ToString();
            txtnome.Text = al.nome;
            txtnota.Text = al.nota.ToString();
        }


        public fmrAlunos()
        {
            InitializeComponent();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                i = 0;
                //txtnum.Text = a[i].numero.ToString();
                //txtnome.Text = a[i].nome;
                //txtnota.Text = a[i].nota.ToString();
                MostrarDados(a[i]);
            }
            else
                MessageBox.Show("Não há alunos");
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
                if (i>0)
                {
                    i--;
                    //txtnum.Text = a[i].numero.ToString();
                    //txtnome.Text = a[i].nome;
                    //txtnota.Text = a[i].nota.ToString();
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
                    //txtnum.Text = a[i].numero.ToString();
                    //txtnome.Text = a[i].nome;
                    //txtnota.Text = a[i].nota.ToString();
                    MostrarDados(a[i]);
                }
                else
                    MessageBox.Show("Não pode passar do ultimo");
            else
                MessageBox.Show("Não há alunos");
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                i = a.Length-1;
                txtnum.Text = a[i].numero.ToString();
                txtnome.Text = a[i].nome;
                txtnota.Text = a[i].nota.ToString();
            }
            else
                MessageBox.Show("Não há alunos");
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Array.Resize<Aluno>(ref a, a.Length + 1);
            i = a.Length - 1;
            a[i].numero = long.Parse(txtnum.Text);
            a[i].nome = txtnome.Text;
            a[i].nota = int.Parse(txtnota.Text);
            
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            if(a.Length>0)
            {
                a[i].numero = long.Parse(txtnum.Text);
                a[i].nome = txtnome.Text;
                a[i].nota = int.Parse(txtnota.Text);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if(a.Length>0)
            {
                Aluno[] a2 = new Aluno[a.Length];
                a.CopyTo(a2, 0);
                a = new Aluno[a2.Length-1];
                for (int j = 0; j < i; j++)
                    a[j] = a2[j];
                for (int j = i + 1; j < a2.Length; j++)
                    a[j - 1] = a2[j];
                if (i > a.Length - 1) i = a.Length - 1;
                if (a.Length > 0)
                {
                    txtnum.Text = a[i].numero.ToString();
                    txtnome.Text = a[i].nome;
                    txtnota.Text = a[i].nota.ToString();
                }
                else
                {
                    txtnum.Text = "";
                    txtnome.Text = "";
                    txtnota.Text = "";
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
    }
}
