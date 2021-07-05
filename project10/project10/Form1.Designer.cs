namespace project10
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
            this.txtn = new System.Windows.Forms.TextBox();
            this.btncacho = new System.Windows.Forms.Button();
            this.btncomer = new System.Windows.Forms.Button();
            this.btnver = new System.Windows.Forms.Button();
            this.lblcacho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(73, 38);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(138, 20);
            this.txtn.TabIndex = 0;
            // 
            // btncacho
            // 
            this.btncacho.Location = new System.Drawing.Point(12, 118);
            this.btncacho.Name = "btncacho";
            this.btncacho.Size = new System.Drawing.Size(75, 23);
            this.btncacho.TabIndex = 1;
            this.btncacho.Text = "Cacho";
            this.btncacho.UseVisualStyleBackColor = true;
            this.btncacho.Click += new System.EventHandler(this.btncacho_Click);
            // 
            // btncomer
            // 
            this.btncomer.Location = new System.Drawing.Point(106, 118);
            this.btncomer.Name = "btncomer";
            this.btncomer.Size = new System.Drawing.Size(75, 23);
            this.btncomer.TabIndex = 2;
            this.btncomer.Text = "Comer";
            this.btncomer.UseVisualStyleBackColor = true;
            this.btncomer.Click += new System.EventHandler(this.btncomer_Click);
            // 
            // btnver
            // 
            this.btnver.Location = new System.Drawing.Point(201, 118);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(75, 23);
            this.btnver.TabIndex = 3;
            this.btnver.Text = "Ver";
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // lblcacho
            // 
            this.lblcacho.AutoSize = true;
            this.lblcacho.Location = new System.Drawing.Point(33, 198);
            this.lblcacho.Name = "lblcacho";
            this.lblcacho.Size = new System.Drawing.Size(0, 13);
            this.lblcacho.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 265);
            this.Controls.Add(this.lblcacho);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.btncomer);
            this.Controls.Add(this.btncacho);
            this.Controls.Add(this.txtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Button btncacho;
        private System.Windows.Forms.Button btncomer;
        private System.Windows.Forms.Button btnver;
        private System.Windows.Forms.Label lblcacho;
    }
}

