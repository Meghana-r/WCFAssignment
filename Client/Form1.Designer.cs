namespace Client
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
            this.btnSelf = new System.Windows.Forms.Button();
            this.txtCardno = new System.Windows.Forms.TextBox();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.txtTransact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelf
            // 
            this.btnSelf.Location = new System.Drawing.Point(231, 328);
            this.btnSelf.Name = "btnSelf";
            this.btnSelf.Size = new System.Drawing.Size(75, 23);
            this.btnSelf.TabIndex = 0;
            this.btnSelf.Text = "Self Hosting";
            this.btnSelf.UseVisualStyleBackColor = true;
            this.btnSelf.Click += new System.EventHandler(this.btnSelf_Click);
            // 
            // txtCardno
            // 
            this.txtCardno.Location = new System.Drawing.Point(369, 53);
            this.txtCardno.Name = "txtCardno";
            this.txtCardno.Size = new System.Drawing.Size(100, 20);
            this.txtCardno.TabIndex = 1;
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(369, 128);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(100, 20);
            this.txtCvv.TabIndex = 3;
            // 
            // txtTransact
            // 
            this.txtTransact.Location = new System.Drawing.Point(369, 201);
            this.txtTransact.Name = "txtTransact";
            this.txtTransact.Size = new System.Drawing.Size(100, 20);
            this.txtTransact.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Card Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter CVV number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter transaction Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 391);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTransact);
            this.Controls.Add(this.txtCvv);
            this.Controls.Add(this.txtCardno);
            this.Controls.Add(this.btnSelf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelf;
        private System.Windows.Forms.TextBox txtCardno;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.TextBox txtTransact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

