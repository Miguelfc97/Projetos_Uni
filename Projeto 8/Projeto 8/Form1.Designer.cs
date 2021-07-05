namespace Projeto_8
{
    partial class Form1
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
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnupd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.txtordem = new System.Windows.Forms.TextBox();
            this.txtespecie = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(40, 268);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(75, 23);
            this.btnfirst.TabIndex = 0;
            this.btnfirst.Text = "|<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(121, 268);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(75, 23);
            this.btnprev.TabIndex = 1;
            this.btnprev.Text = "<";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(202, 268);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 2;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(283, 268);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(75, 23);
            this.btnlast.TabIndex = 3;
            this.btnlast.Text = ">|";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(64, 311);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(80, 30);
            this.btnnew.TabIndex = 4;
            this.btnnew.Text = "Novo";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnupd
            // 
            this.btnupd.Location = new System.Drawing.Point(150, 311);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(80, 30);
            this.btnupd.TabIndex = 5;
            this.btnupd.Text = "Alterar";
            this.btnupd.UseVisualStyleBackColor = true;
            this.btnupd.Click += new System.EventHandler(this.btnupd_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(236, 311);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(80, 30);
            this.btndel.TabIndex = 6;
            this.btndel.Text = "Apagar";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // txtordem
            // 
            this.txtordem.Location = new System.Drawing.Point(157, 21);
            this.txtordem.Name = "txtordem";
            this.txtordem.Size = new System.Drawing.Size(140, 20);
            this.txtordem.TabIndex = 7;
            // 
            // txtespecie
            // 
            this.txtespecie.Location = new System.Drawing.Point(157, 58);
            this.txtespecie.Name = "txtespecie";
            this.txtespecie.Size = new System.Drawing.Size(140, 20);
            this.txtespecie.TabIndex = 8;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(157, 96);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(140, 20);
            this.txtnome.TabIndex = 9;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(157, 189);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(140, 20);
            this.txtvalor.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "NOrdem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Especie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data de Entrada";
            // 
            // dtpdata
            // 
            this.dtpdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdata.Location = new System.Drawing.Point(157, 145);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(105, 20);
            this.dtpdata.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Valor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 373);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpdata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtespecie);
            this.Controls.Add(this.txtordem);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupd);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnfirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnupd;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.TextBox txtordem;
        private System.Windows.Forms.TextBox txtespecie;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.Label label5;
    }
}

