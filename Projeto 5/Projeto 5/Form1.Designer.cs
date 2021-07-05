namespace Projeto_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtfatorial = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfatorial2 = new System.Windows.Forms.TextBox();
            this.btnarranjos = new System.Windows.Forms.Button();
            this.btncombinacoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&N";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(15, 129);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(82, 24);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Permutacoes";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtfatorial
            // 
            this.txtfatorial.Location = new System.Drawing.Point(86, 26);
            this.txtfatorial.Name = "txtfatorial";
            this.txtfatorial.Size = new System.Drawing.Size(152, 20);
            this.txtfatorial.TabIndex = 2;
            this.txtfatorial.Validating += new System.ComponentModel.CancelEventHandler(this.txtfatorial_Validating);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(12, 231);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 8;
            this.lblresultado.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&P";
            // 
            // txtfatorial2
            // 
            this.txtfatorial2.Location = new System.Drawing.Point(86, 75);
            this.txtfatorial2.Name = "txtfatorial2";
            this.txtfatorial2.Size = new System.Drawing.Size(152, 20);
            this.txtfatorial2.TabIndex = 4;
            this.txtfatorial2.Validating += new System.ComponentModel.CancelEventHandler(this.txtfatorial_Validating);
            // 
            // btnarranjos
            // 
            this.btnarranjos.Location = new System.Drawing.Point(116, 130);
            this.btnarranjos.Name = "btnarranjos";
            this.btnarranjos.Size = new System.Drawing.Size(82, 24);
            this.btnarranjos.TabIndex = 6;
            this.btnarranjos.Text = "Arranjos";
            this.btnarranjos.UseVisualStyleBackColor = true;
            this.btnarranjos.Click += new System.EventHandler(this.btnarranjos_Click);
            // 
            // btncombinacoes
            // 
            this.btncombinacoes.Location = new System.Drawing.Point(219, 130);
            this.btncombinacoes.Name = "btncombinacoes";
            this.btncombinacoes.Size = new System.Drawing.Size(82, 24);
            this.btncombinacoes.TabIndex = 7;
            this.btncombinacoes.Text = "Combinacoes";
            this.btncombinacoes.UseVisualStyleBackColor = true;
            this.btncombinacoes.Click += new System.EventHandler(this.btncombinacoes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 277);
            this.Controls.Add(this.btncombinacoes);
            this.Controls.Add(this.btnarranjos);
            this.Controls.Add(this.txtfatorial2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtfatorial);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtfatorial;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfatorial2;
        private System.Windows.Forms.Button btnarranjos;
        private System.Windows.Forms.Button btncombinacoes;
    }
}

