namespace bai17_Tinhlaisuat
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
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtLai = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstKq = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(143, 71);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(100, 20);
            this.txtTien.TabIndex = 0;
            // 
            // txtLai
            // 
            this.txtLai.Location = new System.Drawing.Point(143, 152);
            this.txtLai.Name = "txtLai";
            this.txtLai.Size = new System.Drawing.Size(100, 20);
            this.txtLai.TabIndex = 0;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(143, 239);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 20);
            this.txtNam.TabIndex = 0;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(297, 108);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(87, 107);
            this.btnTinh.TabIndex = 1;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lãi suất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm";
            // 
            // lstKq
            // 
            this.lstKq.FormattingEnabled = true;
            this.lstKq.Location = new System.Drawing.Point(450, 60);
            this.lstKq.Name = "lstKq";
            this.lstKq.Size = new System.Drawing.Size(187, 199);
            this.lstKq.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstKq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtLai);
            this.Controls.Add(this.txtTien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtLai;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstKq;
    }
}

