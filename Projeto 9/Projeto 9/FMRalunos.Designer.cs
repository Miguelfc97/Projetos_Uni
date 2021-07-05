namespace Projeto_9
{
    partial class FMRalunos
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupd = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(101, 90);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(114, 20);
            this.txtnome.TabIndex = 21;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(101, 47);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(114, 20);
            this.txtnumero.TabIndex = 20;
            this.txtnumero.Validating += new System.ComponentModel.CancelEventHandler(this.ValidaNumero);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(40, 93);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(35, 13);
            this.lblnome.TabIndex = 19;
            this.lblnome.Text = "Nome";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(37, 50);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(44, 13);
            this.lblnumero.TabIndex = 18;
            this.lblnumero.Text = "Numero";
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(220, 215);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(79, 33);
            this.btndel.TabIndex = 17;
            this.btndel.Text = "Apagar";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupd
            // 
            this.btnupd.Location = new System.Drawing.Point(139, 215);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(79, 33);
            this.btnupd.TabIndex = 16;
            this.btnupd.Text = "Alterar";
            this.btnupd.UseVisualStyleBackColor = true;
            this.btnupd.Click += new System.EventHandler(this.btnupd_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(58, 215);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(79, 33);
            this.btnnew.TabIndex = 15;
            this.btnnew.Text = "Novo";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(263, 170);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(79, 27);
            this.btnlast.TabIndex = 14;
            this.btnlast.Text = ">|";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(182, 170);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(79, 27);
            this.btnnext.TabIndex = 13;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(101, 170);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(79, 27);
            this.btnprev.TabIndex = 12;
            this.btnprev.Text = "<";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(20, 170);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(79, 27);
            this.btnfirst.TabIndex = 11;
            this.btnfirst.Text = "|<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // FMRalunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 279);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupd);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnfirst);
            this.Name = "FMRalunos";
            this.Text = "FMRalunos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMRalunos_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMRalunos_FormClosed);
            this.Shown += new System.EventHandler(this.FMRalunos_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupd;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnfirst;
    }
}