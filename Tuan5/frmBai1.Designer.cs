namespace Tuan5
{
    partial class frmBai1
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lbKQ = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnS = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(55, 28);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(62, 20);
            this.txtA.TabIndex = 0;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(27, 31);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(22, 13);
            this.lbA.TabIndex = 1;
            this.lbA.Text = "a =";
            this.lbA.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(174, 31);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(22, 13);
            this.lbB.TabIndex = 3;
            this.lbB.Text = "b =";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(202, 28);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(57, 20);
            this.txtB.TabIndex = 2;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Location = new System.Drawing.Point(27, 76);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(46, 13);
            this.lbKQ.TabIndex = 5;
            this.lbKQ.Text = "Kết Quả";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(83, 73);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(176, 20);
            this.txtKQ.TabIndex = 4;
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(19, 117);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(54, 30);
            this.btnS.TabIndex = 6;
            this.btnS.Text = "+";
            this.btnS.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(83, 117);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(46, 30);
            this.btnD.TabIndex = 7;
            this.btnD.Text = "-";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(145, 117);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(51, 30);
            this.btnX.TabIndex = 8;
            this.btnX.Text = "x";
            this.btnX.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(211, 117);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(48, 30);
            this.btnC.TabIndex = 9;
            this.btnC.Text = "/";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 182);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.txtA);
            this.Name = "frmBai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBai1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnC;
    }
}

