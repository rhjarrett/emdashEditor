namespace emdashEditor
{
    partial class frmAbout
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
            label1 = new System.Windows.Forms.Label();
            labelDescription = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            labelVersion = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            labelProduct = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            labelCompany = new System.Windows.Forms.Label();
            labelCopyright = new System.Windows.Forms.Label();
            buttonClose = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Description";
            // 
            // labelDescription
            // 
            labelDescription.Location = new System.Drawing.Point(92, 35);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new System.Drawing.Size(266, 43);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Version";
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Location = new System.Drawing.Point(92, 78);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new System.Drawing.Size(38, 15);
            labelVersion.TabIndex = 3;
            labelVersion.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Product";
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Location = new System.Drawing.Point(92, 11);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new System.Drawing.Size(38, 15);
            labelProduct.TabIndex = 5;
            labelProduct.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 102);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Company";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 126);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 15);
            label5.TabIndex = 7;
            label5.Text = "Copyright";
            // 
            // labelCompany
            // 
            labelCompany.AutoSize = true;
            labelCompany.Location = new System.Drawing.Point(92, 102);
            labelCompany.Name = "labelCompany";
            labelCompany.Size = new System.Drawing.Size(38, 15);
            labelCompany.TabIndex = 8;
            labelCompany.Text = "label6";
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Location = new System.Drawing.Point(92, 127);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new System.Drawing.Size(38, 15);
            labelCopyright.TabIndex = 9;
            labelCopyright.Text = "label6";
            // 
            // buttonClose
            // 
            buttonClose.BackColor = System.Drawing.Color.SpringGreen;
            buttonClose.Location = new System.Drawing.Point(148, 153);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(75, 23);
            buttonClose.TabIndex = 10;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(370, 185);
            ControlBox = false;
            Controls.Add(buttonClose);
            Controls.Add(labelCopyright);
            Controls.Add(labelCompany);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(labelProduct);
            Controls.Add(label3);
            Controls.Add(labelVersion);
            Controls.Add(label2);
            Controls.Add(labelDescription);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAbout";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Button buttonClose;
    }
}