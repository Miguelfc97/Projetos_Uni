namespace Projeto_3
{
    partial class FRMcontas
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
            this.txtoper2 = new System.Windows.Forms.TextBox();
            this.txtoper1 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnsomar = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtoper2
            // 
            this.txtoper2.Location = new System.Drawing.Point(84, 73);
            this.txtoper2.Name = "txtoper2";
            this.txtoper2.Size = new System.Drawing.Size(182, 20);
            this.txtoper2.TabIndex = 0;
            // 
            // txtoper1
            // 
            this.txtoper1.Location = new System.Drawing.Point(84, 38);
            this.txtoper1.Name = "txtoper1";
            this.txtoper1.Size = new System.Drawing.Size(182, 20);
            this.txtoper1.TabIndex = 1;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(84, 115);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(182, 20);
            this.txtresultado.TabIndex = 2;
            // 
            // btnsomar
            // 
            this.btnsomar.Location = new System.Drawing.Point(66, 177);
            this.btnsomar.Name = "btnsomar";
            this.btnsomar.Size = new System.Drawing.Size(46, 29);
            this.btnsomar.TabIndex = 3;
            this.btnsomar.Text = "+";
            this.btnsomar.UseVisualStyleBackColor = true;
            this.btnsomar.Click += new System.EventHandler(this.calcular);
            // 
            // btnmult
            // 
            this.btnmult.Location = new System.Drawing.Point(220, 177);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(46, 29);
            this.btnmult.TabIndex = 4;
            this.btnmult.Text = "x";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.calcular);
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(297, 177);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(46, 29);
            this.btndividir.TabIndex = 5;
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.calcular);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(143, 177);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(46, 29);
            this.btnsub.TabIndex = 6;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.calcular);
            // 
            // FRMcontas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 292);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btnsomar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtoper1);
            this.Controls.Add(this.txtoper2);
            this.Name = "FRMcontas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtoper2;
        private System.Windows.Forms.TextBox txtoper1;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnsomar;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnsub;
    }
}

