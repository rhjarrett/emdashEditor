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
            clearButton = new System.Windows.Forms.Button();
            pasteButton = new System.Windows.Forms.Button();
            convertButton = new System.Windows.Forms.Button();
            copyButton = new System.Windows.Forms.Button();
            topTextBox = new System.Windows.Forms.RichTextBox();
            bottomTextBox = new System.Windows.Forms.RichTextBox();
            statusLabel = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // clearButton
            // 
            clearButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            clearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            clearButton.Location = new System.Drawing.Point(747, 44);
            clearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(93, 35);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // pasteButton
            // 
            pasteButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pasteButton.BackColor = System.Drawing.Color.Cyan;
            pasteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            pasteButton.Location = new System.Drawing.Point(747, 118);
            pasteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pasteButton.Name = "pasteButton";
            pasteButton.Size = new System.Drawing.Size(93, 35);
            pasteButton.TabIndex = 2;
            pasteButton.Text = "Paste";
            pasteButton.UseVisualStyleBackColor = false;
            pasteButton.Click += PasteButton_Click;
            // 
            // convertButton
            // 
            convertButton.BackColor = System.Drawing.Color.RoyalBlue;
            convertButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            convertButton.ForeColor = System.Drawing.Color.Yellow;
            convertButton.Location = new System.Drawing.Point(323, 328);
            convertButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            convertButton.Name = "convertButton";
            convertButton.Size = new System.Drawing.Size(93, 35);
            convertButton.TabIndex = 3;
            convertButton.Text = "↓ Convert ↓";
            convertButton.UseVisualStyleBackColor = false;
            convertButton.Click += ConvertButton_Click;
            // 
            // copyButton
            // 
            copyButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            copyButton.BackColor = System.Drawing.Color.GreenYellow;
            copyButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            copyButton.Location = new System.Drawing.Point(747, 419);
            copyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            copyButton.Name = "copyButton";
            copyButton.Size = new System.Drawing.Size(93, 35);
            copyButton.TabIndex = 5;
            copyButton.Text = "Copy";
            copyButton.UseVisualStyleBackColor = false;
            copyButton.Click += CopyButton_Click;
            // 
            // topTextBox
            // 
            topTextBox.Location = new System.Drawing.Point(16, 44);
            topTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            topTextBox.Name = "topTextBox";
            topTextBox.Size = new System.Drawing.Size(699, 230);
            topTextBox.TabIndex = 6;
            topTextBox.Text = "";
            topTextBox.TextChanged += TopTextBox_TextChanged;
            // 
            // bottomTextBox
            // 
            bottomTextBox.Location = new System.Drawing.Point(15, 369);
            bottomTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bottomTextBox.Name = "bottomTextBox";
            bottomTextBox.Size = new System.Drawing.Size(699, 230);
            bottomTextBox.TabIndex = 7;
            bottomTextBox.Text = "";
            // 
            // statusLabel
            // 
            statusLabel.BackColor = System.Drawing.Color.Yellow;
            statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            statusLabel.ForeColor = System.Drawing.Color.Red;
            statusLabel.Location = new System.Drawing.Point(15, 298);
            statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(700, 27);
            statusLabel.TabIndex = 8;
            statusLabel.Text = "Ready to convert em-dashes and space-hyphens to commas";
            statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(850, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(850, 611);
            Controls.Add(statusLabel);
            Controls.Add(bottomTextBox);
            Controls.Add(topTextBox);
            Controls.Add(copyButton);
            Controls.Add(convertButton);
            Controls.Add(pasteButton);
            Controls.Add(clearButton);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "emdashEditor";
            Resize += MainForm_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.RichTextBox topTextBox;
        private System.Windows.Forms.RichTextBox bottomTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

