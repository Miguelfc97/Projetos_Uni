namespace Projeto_9
{
    partial class FRMcursos
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(29, 154);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(79, 27);
            this.btnfirst.TabIndex = 0;
            this.btnfirst.Text = "|<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(110, 154);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(79, 27);
            this.btnprev.TabIndex = 1;
            this.btnprev.Text = "<";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(191, 154);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(79, 27);
            this.btnnext.TabIndex = 2;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(272, 154);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(79, 27);
            this.btnlast.TabIndex = 3;
            this.btnlast.Text = ">|";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(67, 199);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(79, 33);
            this.btnnew.TabIndex = 4;
            this.btnnew.Text = "Novo";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnupd
            // 
            this.btnupd.Location = new System.Drawing.Point(148, 199);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(79, 33);
            this.btnupd.TabIndex = 5;
            this.btnupd.Text = "Alterar";
            this.btnupd.UseVisualStyleBackColor = true;
            this.btnupd.Click += new System.EventHandler(this.btnupd_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(229, 199);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(79, 33);
            this.btndel.TabIndex = 6;
            this.btndel.Text = "Apagar";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(46, 34);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 7;
            this.lblcodigo.Text = "Codigo";
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Location = new System.Drawing.Point(49, 77);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(55, 13);
            this.lbldescricao.TabIndex = 8;
            this.lbldescricao.Text = "Descricao";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(110, 31);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(114, 20);
            this.txtcodigo.TabIndex = 9;
            this.txtcodigo.Validating += new System.ComponentModel.CancelEventHandler(this.ValidaCodigo);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(110, 74);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(114, 20);
            this.txtdescricao.TabIndex = 10;
            // 
            // FRMcursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 279);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupd);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnfirst);
            this.Name = "FRMcursos";
            this.Text = "FRMcursos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMcursos_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMcursos_FormClosed);
            this.Shown += new System.EventHandler(this.FRMcursos_Shown);
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
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtdescricao;
    }
}