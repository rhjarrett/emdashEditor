namespace emdashEditor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.clearButton = new System.Windows.Forms.Button();
            this.pasteButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.topTextBox = new System.Windows.Forms.RichTextBox();
            this.bottomTextBox = new System.Windows.Forms.RichTextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(640, 38);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 30);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // pasteButton
            // 
            this.pasteButton.Location = new System.Drawing.Point(640, 102);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(80, 30);
            this.pasteButton.TabIndex = 2;
            this.pasteButton.Text = "Paste";
            this.pasteButton.UseVisualStyleBackColor = true;
            this.pasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(279, 248);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(80, 30);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "↓ Convert ↓";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(640, 351);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(80, 30);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // topTextBox
            // 
            this.topTextBox.Location = new System.Drawing.Point(12, 12);
            this.topTextBox.Name = "topTextBox";
            this.topTextBox.Size = new System.Drawing.Size(600, 200);
            this.topTextBox.TabIndex = 6;
            this.topTextBox.Text = "";
            this.topTextBox.TextChanged += new System.EventHandler(this.TopTextBox_TextChanged);
            // 
            // bottomTextBox
            // 
            this.bottomTextBox.Location = new System.Drawing.Point(12, 293);
            this.bottomTextBox.Name = "bottomTextBox";
            this.bottomTextBox.Size = new System.Drawing.Size(600, 200);
            this.bottomTextBox.TabIndex = 7;
            this.bottomTextBox.Text = "";
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Yellow;
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(12, 221);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(600, 24);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Ready to convert em-dashes and space-hyphens to commas";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 505);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.bottomTextBox);
            this.Controls.Add(this.topTextBox);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.pasteButton);
            this.Controls.Add(this.clearButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Em-Dash Text Converter";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.RichTextBox topTextBox;
        private System.Windows.Forms.RichTextBox bottomTextBox;
        private System.Windows.Forms.Label statusLabel;
    }
}

