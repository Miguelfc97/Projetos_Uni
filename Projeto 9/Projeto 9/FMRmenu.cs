using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Projeto_9
{
    public partial class FMRmenu : Form
    {
        public alunos[] a = new alunos[] { };
        public curso[] c = new curso[] { };
        
        public FMRmenu()
        {
            InitializeComponent();
        }

        private void btncurso_Click(object sender, EventArgs e)
        {
            FRMcursos f = new FRMcursos();
            f.Show(this);
        }

        private void btnalunos_Click(object sender, EventArgs e)
        {
            FMRalunos f = new FMRalunos();
            f.Show(this);
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            if (ofdimport.ShowDialog(this) == DialogResult.OK)
            {
                string filename = ofdimport.FileName;
                StreamReader sr = new StreamReader(filename);
                XmlSerializer dser = new XmlSerializer(a.GetType());
                a = (animal[])dser.Deserialize(sr);
                sr.Close();
                if (i > a.Length - 1) i = a.Length - 1;
                if (a.Length > 0)
                {
                    MostrarDados(a[i]);
                }
                else
                {
                    txtordem.Text = "";
                    lbxespecie.SelectedIndex = -1;
                    txtnome.Text = "";
                    txtvalor.Text = "";
                    dtpdata.Value = DateTime.Today;
                }

            }
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            if (sfdexport.ShowDialog(this) == DialogResult.OK)
            {
                string filename = sfdexport.FileName;
                if (File.Exists(filename))
                    File.Delete(filename);
                StreamWriter sw = new StreamWriter(filename);
                XmlSerializer ser = new XmlSerializer(a.GetType());
                ser.Serialize(sw, a);
                sw.Close();
            }
        }
    }
}
