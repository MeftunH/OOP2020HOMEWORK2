namespace NDP_ODEV2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtx = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.btnarkadasmi = new System.Windows.Forms.Button();
            this.btnson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(57, 76);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(128, 22);
            this.txtx.TabIndex = 2;
            this.txtx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtx_KeyPress);
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(57, 155);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(128, 22);
            this.txty.TabIndex = 3;
            this.txty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txty_KeyPress);
            // 
            // btnarkadasmi
            // 
            this.btnarkadasmi.Location = new System.Drawing.Point(12, 227);
            this.btnarkadasmi.Name = "btnarkadasmi";
            this.btnarkadasmi.Size = new System.Drawing.Size(107, 45);
            this.btnarkadasmi.TabIndex = 4;
            this.btnarkadasmi.Text = "Arkadas mi";
            this.btnarkadasmi.UseVisualStyleBackColor = true;
            this.btnarkadasmi.Click += new System.EventHandler(this.btnarkadasmi_Click);
            // 
            // btnson
            // 
            this.btnson.Location = new System.Drawing.Point(170, 227);
            this.btnson.Name = "btnson";
            this.btnson.Size = new System.Drawing.Size(107, 45);
            this.btnson.TabIndex = 5;
            this.btnson.Text = "Son";
            this.btnson.UseVisualStyleBackColor = true;
            this.btnson.Click += new System.EventHandler(this.btnson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 288);
            this.Controls.Add(this.btnson);
            this.Controls.Add(this.btnarkadasmi);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.Button btnarkadasmi;
        private System.Windows.Forms.Button btnson;
    }
}

