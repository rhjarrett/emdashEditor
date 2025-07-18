using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emdashEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            LayoutControls();
        }

        private void LayoutControls()
        {
            const int margin = 20;
            const int buttonSpacing = 10;
            const int convertButtonHeight = 40;
            const int convertButtonSpacing = 15;
            const int statusLabelHeight = 25;
            const int statusLabelSpacing = 10;

            // Calculate button area width (button width + spacing)
            int buttonAreaWidth = clearButton.Width + buttonSpacing;

            // Calculate textbox width (form width - margins - button area)
            int textBoxWidth = this.ClientSize.Width - (margin * 2) - buttonAreaWidth;

            // Calculate available height for textboxes (accounting for status label)
            int totalAvailableHeight = this.ClientSize.Height - (margin * 2) - convertButtonHeight - (convertButtonSpacing * 2) - statusLabelHeight - statusLabelSpacing;

            // Each textbox gets half the available height
            int textBoxHeight = totalAvailableHeight / 2;

            // Position top textbox (anchored to top)
            topTextBox.Location = new Point(margin, margin);
            topTextBox.Size = new Size(textBoxWidth, textBoxHeight);

            // Position buttons beside top textbox
            int buttonX = margin + textBoxWidth + buttonSpacing;
            clearButton.Location = new Point(buttonX, margin);
            pasteButton.Location = new Point(buttonX, margin + clearButton.Height + 10);

            // Position convert button (centered between textboxes)
            int convertButtonY = margin + textBoxHeight + convertButtonSpacing;
            int convertButtonX = (this.ClientSize.Width - convertButton.Width) / 2;
            convertButton.Location = new Point(convertButtonX, convertButtonY);

            // Position bottom textbox (anchored to where convert button ends)
            int bottomTextBoxY = convertButtonY + convertButtonHeight + convertButtonSpacing;
            bottomTextBox.Location = new Point(margin, bottomTextBoxY);
            bottomTextBox.Size = new Size(textBoxWidth, textBoxHeight);

            // Position copy button beside bottom textbox
            copyButton.Location = new Point(buttonX, bottomTextBoxY);

            // Position status label below bottom textbox
            int statusLabelY = bottomTextBoxY + textBoxHeight + statusLabelSpacing;
            statusLabel.Location = new Point(margin, statusLabelY);
            statusLabel.Size = new Size(textBoxWidth, statusLabelHeight);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            topTextBox.Clear();
            bottomTextBox.Clear();
            statusLabel.Text = "Ready to convert em-dashes and space-hyphens to commas";
            statusLabel.ForeColor = Color.DarkSlateGray;
            topTextBox.Focus();
        }

        private void TopTextBox_TextChanged(object sender, EventArgs e)
        {
            // Use a timer to delay highlighting to avoid performance issues during typing
            if (highlightTimer != null)
            {
                highlightTimer.Stop();
                highlightTimer.Dispose();
            }

            highlightTimer = new Timer();
            highlightTimer.Interval = 500; // 500ms delay
            highlightTimer.Tick += (s, args) =>
            {
                HighlightEmDashes();
                highlightTimer.Stop();
                highlightTimer.Dispose();
                highlightTimer = null;
            };
            highlightTimer.Start();
        }

        private Timer highlightTimer;

        private void HighlightEmDashes()
        {
            if (string.IsNullOrEmpty(topTextBox.Text))
                return;

            // Store current selection to restore it later
            int selectionStart = topTextBox.SelectionStart;
            int selectionLength = topTextBox.SelectionLength;

            // Temporarily disable text change events to prevent recursion
            topTextBox.TextChanged -= TopTextBox_TextChanged;

            try
            {
                // Clear all formatting first
                topTextBox.SelectAll();
                topTextBox.SelectionBackColor = Color.White;
                topTextBox.SelectionColor = Color.Black;

                // Find and highlight em-dashes that have alphanumerics on both sides
                string emDashPattern = @"(\w)—(\w)";
                MatchCollection emDashMatches = Regex.Matches(topTextBox.Text, emDashPattern);

                foreach (Match match in emDashMatches)
                {
                    // Find the position of the em-dash within the match (it's between the two groups)
                    int emDashPosition = match.Index + match.Groups[1].Length;

                    // Select just the em-dash character
                    topTextBox.Select(emDashPosition, 1);
                    topTextBox.SelectionBackColor = Color.Yellow;
                    topTextBox.SelectionColor = Color.Red;
                }

                // Find and highlight " - " (space-hyphen-space) patterns
                string spaceHyphenPattern = @"(\w) - (\w)";
                MatchCollection spaceHyphenMatches = Regex.Matches(topTextBox.Text, spaceHyphenPattern);

                foreach (Match match in spaceHyphenMatches)
                {
                    // Find the position of " - " within the match (it's between the two groups)
                    int spaceHyphenPosition = match.Index + match.Groups[1].Length;

                    // Select the " - " (3 characters)
                    topTextBox.Select(spaceHyphenPosition, 3);
                    topTextBox.SelectionBackColor = Color.Orange;
                    topTextBox.SelectionColor = Color.DarkRed;
                }

                // Also highlight standalone em-dashes (not between alphanumerics) in a different color
                string standalonePattern = @"(?<!\w)—(?!\w)|(?<!\w)—(?=\w)|(?<=\w)—(?!\w)";
                MatchCollection standaloneMatches = Regex.Matches(topTextBox.Text, standalonePattern);

                foreach (Match match in standaloneMatches)
                {
                    topTextBox.Select(match.Index, 1);
                    topTextBox.SelectionBackColor = Color.LightBlue;
                    topTextBox.SelectionColor = Color.DarkBlue;
                }
            }
            finally
            {
                // Restore original selection
                topTextBox.Select(selectionStart, selectionLength);

                // Re-enable text change events
                topTextBox.TextChanged += TopTextBox_TextChanged;
            }
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Clipboard.ContainsText())
                {
                    topTextBox.Text = Clipboard.GetText();
                    HighlightEmDashes();
                }
                else
                {
                    MessageBox.Show("No text found in clipboard.", "Paste",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error pasting from clipboard: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string inputText = topTextBox.Text;

                if (string.IsNullOrEmpty(inputText))
                {
                    bottomTextBox.Clear();
                    return;
                }

                // Start with the input text
                string convertedText = inputText;

                // First, replace em-dashes with alphanumeric characters on both sides
                string emDashPattern = @"(\w)—(\w)";
                convertedText = Regex.Replace(convertedText, emDashPattern, "$1, $2");

                // Then, replace " - " (space-hyphen-space) with ", "
                string spaceHyphenPattern = @"(\w) - (\w)";
                convertedText = Regex.Replace(convertedText, spaceHyphenPattern, "$1, $2");

                bottomTextBox.Text = convertedText;

                // Highlight the changes in the bottom text box
                HighlightConversions(inputText, convertedText);

                // Count total conversions
                int emDashConversions = Regex.Matches(inputText, emDashPattern).Count;
                int spaceHyphenConversions = Regex.Matches(inputText, spaceHyphenPattern).Count;
                int totalConversions = emDashConversions + spaceHyphenConversions;

                // Show conversion information in status label and title bar
                if (totalConversions > 0)
                {
                    string conversionDetails = "";
                    if (emDashConversions > 0 && spaceHyphenConversions > 0)
                        conversionDetails = $"{emDashConversions} em-dash(es), {spaceHyphenConversions} space-hyphen(s)";
                    else if (emDashConversions > 0)
                        conversionDetails = $"{emDashConversions} em-dash(es)";
                    else
                        conversionDetails = $"{spaceHyphenConversions} space-hyphen(s)";

                    string statusMessage = $"✓ Converted {totalConversions} item(s): {conversionDetails}";
                    statusLabel.Text = statusMessage;
                    statusLabel.ForeColor = Color.DarkGreen;

                    this.Text = $"Em-Dash Text Converter - {totalConversions} conversion(s) made";

                    // Reset title after 4 seconds
                    Timer timer = new Timer();
                    timer.Interval = 4000;
                    timer.Tick += (s, args) =>
                    {
                        this.Text = "Em-Dash Text Converter";
                        timer.Stop();
                        timer.Dispose();
                    };
                    timer.Start();
                }
                else
                {
                    statusLabel.Text = "No conversions needed - no em-dashes or space-hyphens found between alphanumerics";
                    statusLabel.ForeColor = Color.DarkOrange;

                    this.Text = "Em-Dash Text Converter - No conversions needed";

                    Timer timer = new Timer();
                    timer.Interval = 2000;
                    timer.Tick += (s, args) =>
                    {
                        this.Text = "Em-Dash Text Converter";
                        timer.Stop();
                        timer.Dispose();
                    };
                    timer.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during conversion: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HighlightConversions(string originalText, string convertedText)
        {
            if (string.IsNullOrEmpty(convertedText))
                return;

            try
            {
                // Clear all formatting first
                bottomTextBox.SelectAll();
                bottomTextBox.SelectionBackColor = Color.White;
                bottomTextBox.SelectionColor = Color.Black;
                bottomTextBox.SelectionFont = new Font(bottomTextBox.Font, FontStyle.Regular);

                // We need to track both types of conversions and their positions
                var conversions = new List<(int originalPos, int length, string type)>();

                // Find em-dash conversions
                string emDashPattern = @"(\w)—(\w)";
                MatchCollection emDashMatches = Regex.Matches(originalText, emDashPattern);
                foreach (Match match in emDashMatches)
                {
                    int emDashPos = match.Index + match.Groups[1].Length;
                    conversions.Add((emDashPos, 1, "emdash"));
                }

                // Find space-hyphen conversions
                string spaceHyphenPattern = @"(\w) - (\w)";
                MatchCollection spaceHyphenMatches = Regex.Matches(originalText, spaceHyphenPattern);
                foreach (Match match in spaceHyphenMatches)
                {
                    int spaceHyphenPos = match.Index + match.Groups[1].Length;
                    conversions.Add((spaceHyphenPos, 3, "spacehyphen"));
                }

                // Sort conversions by position to process them in order
                conversions.Sort((a, b) => a.originalPos.CompareTo(b.originalPos));

                // Track position offset as we process conversions
                int positionOffset = 0;

                foreach (var conversion in conversions)
                {
                    // Calculate the position in the converted text
                    int convertedPos = conversion.originalPos + positionOffset;

                    // Highlight the ", " (2 characters) in the converted text
                    if (convertedPos + 1 < convertedText.Length)
                    {
                        bottomTextBox.Select(convertedPos, 2);

                        if (conversion.type == "emdash")
                        {
                            // Yellow/green highlighting for em-dash conversions
                            bottomTextBox.SelectionBackColor = Color.LightGreen;
                            bottomTextBox.SelectionColor = Color.DarkGreen;
                        }
                        else
                        {
                            // Orange/red highlighting for space-hyphen conversions
                            bottomTextBox.SelectionBackColor = Color.LightCoral;
                            bottomTextBox.SelectionColor = Color.DarkRed;
                        }

                        bottomTextBox.SelectionFont = new Font(bottomTextBox.Font, FontStyle.Bold);
                    }

                    // Update position offset based on conversion type
                    if (conversion.type == "emdash")
                    {
                        // em-dash (1 char) → ", " (2 chars) = +1 char
                        positionOffset += 1;
                    }
                    else
                    {
                        // " - " (3 chars) → ", " (2 chars) = -1 char
                        positionOffset -= 1;
                    }
                }

                // Clear selection to show all highlights
                bottomTextBox.Select(0, 0);
            }
            catch (Exception ex)
            {
                // If highlighting fails, just continue without highlighting
                System.Diagnostics.Debug.WriteLine($"Highlighting error: {ex.Message}");
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(bottomTextBox.Text))
                {
                    Clipboard.SetText(bottomTextBox.Text);

                    // Brief visual feedback
                    string originalText = copyButton.Text;
                    copyButton.Text = "Copied!";
                    copyButton.BackColor = Color.LightGreen;

                    Timer timer = new Timer();
                    timer.Interval = 1000;
                    timer.Tick += (s, args) =>
                    {
                        copyButton.Text = originalText;
                        copyButton.BackColor = SystemColors.Control;
                        timer.Stop();
                        timer.Dispose();
                    };
                    timer.Start();
                }
                else
                {
                    MessageBox.Show("No text to copy.", "Copy",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error copying to clipboard: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.ShowDialog(this);
        }
    }
}
