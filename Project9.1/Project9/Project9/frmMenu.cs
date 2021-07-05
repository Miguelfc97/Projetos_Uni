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

namespace Project9
{
    public partial class frmMenu : Form
    {
        public Curso[] c = new Curso[] { };
        public Aluno[] a = new Aluno[] { };

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            frmCursos f = new frmCursos();
            f.c = this.c;
            f.Show(this);
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            frmAlunos f = new frmAlunos();
            f.a = this.a;
            f.Show(this);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (ofdImport.ShowDialog(this) == DialogResult.OK)
            {
                ImportExport ie = new ImportExport();
                string filename = ofdImport.FileName;
                StreamReader sr = new StreamReader(filename);
                XmlSerializer dser = new XmlSerializer(ie.GetType());
                ie = (ImportExport)dser.Deserialize(sr);
                a = ie.a;
                c = ie.c;
                sr.Close();

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (sfdExport.ShowDialog(this) == DialogResult.OK)
            {
                string filename = sfdExport.FileName;
                ImportExport ie = new ImportExport();
                if (File.Exists(filename))
                    File.Delete(filename);
                StreamWriter sw = new StreamWriter(filename);
                XmlSerializer ser = new XmlSerializer(ie.GetType());
                ie.a = a;
                ie.c = c;
                ser.Serialize(sw, ie);
                sw.Close();
            }
        }

    }
}
