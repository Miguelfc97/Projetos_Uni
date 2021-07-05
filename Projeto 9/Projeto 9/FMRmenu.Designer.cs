namespace Projeto_9
{
    partial class FMRmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncurso = new System.Windows.Forms.Button();
            this.btnalunos = new System.Windows.Forms.Button();
            this.ofdimport = new System.Windows.Forms.OpenFileDialog();
            this.sfdexport = new System.Windows.Forms.SaveFileDialog();
            this.btnimport = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncurso
            // 
            this.btncurso.Location = new System.Drawing.Point(57, 100);
            this.btncurso.Name = "btncurso";
            this.btncurso.Size = new System.Drawing.Size(183, 43);
            this.btncurso.TabIndex = 0;
            this.btncurso.Text = "Gerir cursos";
            this.btncurso.UseVisualStyleBackColor = true;
            this.btncurso.Click += new System.EventHandler(this.btncurso_Click);
            // 
            // btnalunos
            // 
            this.btnalunos.Location = new System.Drawing.Point(57, 153);
            this.btnalunos.Name = "btnalunos";
            this.btnalunos.Size = new System.Drawing.Size(183, 43);
            this.btnalunos.TabIndex = 1;
            this.btnalunos.Text = "Gerir alunos";
            this.btnalunos.UseVisualStyleBackColor = true;
            this.btnalunos.Click += new System.EventHandler(this.btnalunos_Click);
            // 
            // ofdimport
            // 
            this.ofdimport.Filter = "All files[\".\"]xml files|*xml";
            // 
            // sfdexport
            // 
            this.sfdexport.Filter = "All files[\".\"]xml files|*xml";
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(57, 242);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(65, 29);
            this.btnimport.TabIndex = 2;
            this.btnimport.Text = "Importar";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // btnexport
            // 
            this.btnexport.Location = new System.Drawing.Point(175, 242);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(65, 29);
            this.btnexport.TabIndex = 3;
            this.btnexport.Text = "Exportar";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // FMRmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 310);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.btnalunos);
            this.Controls.Add(this.btncurso);
            this.Name = "FMRmenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncurso;
        private System.Windows.Forms.Button btnalunos;
        private System.Windows.Forms.OpenFileDialog ofdimport;
        private System.Windows.Forms.SaveFileDialog sfdexport;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Button btnexport;
    }
}

