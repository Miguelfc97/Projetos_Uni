using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_8
{
    struct animal
    {
        public int nordem;
        public string especie;
        public string nome;
        public DateTime dataentrada;
        public decimal valor;
    }
    public partial class Form1 : Form
    {
        private int i = 0;
        private animal[] a = new animal[] { };

        private void MostrarDados(animal x)
        {
            txtordem.Text = x.nordem.ToString();
            txtespecie.Text = x.especie;
            txtnome.Text = x.nome;
            txtvalor.Text = x.valor.ToString();
            dtpdata.Value = x.dataentrada;
        }

        public Form1()
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
                MessageBox.Show("Não há animais");
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
                MessageBox.Show("Não há animais");
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
                MessageBox.Show("Não há animais");
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                i = a.Length - 1;
                txtordem.Text = a[i].nordem.ToString();
                txtespecie.Text = a[i].especie;
                txtnome.Text = a[i].nome;
                txtvalor.Text = a[i].valor.ToString();
                dtpdata.Value = a[i].dataentrada;
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Array.Resize<animal>(ref a, a.Length + 1);
            i = a.Length - 1;
            a[i].nordem = int.Parse(txtordem.Text);
            a[i].especie = txtespecie.Text;
            a[i].nome = txtnome.Text;
            a[i].valor = int.Parse(txtvalor.Text);
            a[i].dataentrada = dtpdata.Value;
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                a[i].nordem = int.Parse(txtordem.Text);
                a[i].especie = txtespecie.Text;
                a[i].nome = txtnome.Text;
                a[i].valor = int.Parse(txtvalor.Text);
                a[i].dataentrada = dtpdata.Value;
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                animal[] a2 = new animal[a.Length];
                a.CopyTo(a2, 0);
                a = new animal[a2.Length - 1];
                for (int j = 0; j < i; j++)
                    a[j] = a2[j];
                for (int j = i + 1; j < a2.Length; j++)
                    a[j - 1] = a2[j];
                if (i > a.Length - 1) i = a.Length - 1;
                if (a.Length > 0)
                {
                    txtordem.Text = a[i].nordem.ToString();
                    txtespecie.Text = a[i].especie;
                    txtnome.Text = a[i].nome;
                    txtvalor.Text = a[i].valor.ToString();
                    dtpdata.Value = a[i].dataentrada;
                }
                else
                {
                    txtordem.Text = "";
                    txtespecie.Text = "";
                    txtnome.Text = "";
                    txtvalor.Text = "";
                    dtpdata.Value = DateTime.Today;
                }
            }
            else
                MessageBox.Show("Não há animais");
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
