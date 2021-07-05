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

    public partial class frmCursos : Form
    {
        int i = 0;
        public Curso[] c;

        public frmCursos()
        {
            InitializeComponent();
        }

        void MostraDados(Curso cr)
        {
            txtCodigo.Text = cr.codigo.ToString();
            txtDescricao.Text = cr.descricao;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (c.Length > 0)
                MostraDados(c[i = 0]);
            else
                MessageBox.Show("Tem de ter pelo menos um curso");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (c.Length > 0)
                if (i > 0)
                    MostraDados(c[--i]);
                else
                    MessageBox.Show("Não pode passar para trás do primeiro");
            else
                MessageBox.Show("Tem de ter pelo menos um curso");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (c.Length > 0)
                if (i < c.Length - 1)
                    MostraDados(c[++i]);
                else
                    MessageBox.Show("Não pode passar para lá do último");
            else
                MessageBox.Show("Tem de ter pelo menos um curso");
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (c.Length > 0)
                MostraDados(c[i = c.Length - 1]);
            else
                MessageBox.Show("Tem de ter pelo menos um curso");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Tem de preencher todos os campos");
                return;
            }

            Array.Resize<Curso>(ref c, c.Length + 1);
            c[i = c.Length - 1] = new Curso()
            {
                codigo = int.Parse(txtCodigo.Text),
                descricao = txtDescricao.Text
            };
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Tem de preencher todos os campos");
                return;
            }

            if (c.Length > 0)
                c[i] = new Curso()
                {
                    codigo = int.Parse(txtCodigo.Text),
                    descricao = txtDescricao.Text
                };
            else
                MessageBox.Show("Tem de ter pelo menos um curso");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (c.Length > 0)
            {
                Curso[] cr2 = new Curso[c.Length];
                c.CopyTo(cr2, 0);
                c = new Curso[cr2.Length - 1];
                for (int j = 0; j < i; j++)
                    c[j] = cr2[j];
                for (int j = i + 1; j < cr2.Length; j++)
                    c[j - 1] = cr2[j];
                i = (i > c.Length - 1) ? c.Length - 1 : i;
                if (c.Length > 0)
                    MostraDados(c[i]);
                else
                {
                    txtCodigo.Text = "";
                    txtDescricao.Text = "";
                }

            }
            else
                MessageBox.Show("Tem de ter pelo menos um curso");
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                int j = 0;
                if (!int.TryParse(txtCodigo.Text, out j))
                {
                    e.Cancel = true;
                    MessageBox.Show("Tem de introduzir um número válido");
                }
            }

        }

        private void frmCursos_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenu f = (frmMenu)this.Owner;
            f.c = this.c;
        }

    }
}
