using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diary_Project
{
    public partial class Form1 : Form
    {
        private Label titleLabel;
        public Form1()
        {
            InitializeComponent();
            // Initialize titleLabel
            titleLabel = new Label();

            // Set titleLabel properties
            titleLabel.Text = "Diary"; // Set the title text
            titleLabel.Font = new Font("Arial", 12, FontStyle.Bold); // Set the font
            titleLabel.AutoSize = true; // Adjust the label size automatically
            titleLabel.Location = new Point(10, 10); // Set the position of the label

            // Add titleLabel to the form's Controls collection
            this.Controls.Add(titleLabel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a rounded rectangle region for the form's border
            GraphicsPath path = RoundedRectangle(ClientRectangle, 20); // Adjust the radius as needed
            Region = new Region(path);
        }
        // Helper method to create a rounded rectangle GraphicsPath
        private GraphicsPath RoundedRectangle(Rectangle rectangle, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rectangle.Location, size);
            GraphicsPath path = new GraphicsPath();

            // Top-left corner
            path.AddArc(arc, 180, 90);
            arc.X = rectangle.Right - diameter;

            // Top-right corner
            path.AddArc(arc, 270, 90);
            arc.Y = rectangle.Bottom - diameter;

            // Bottom-right corner
            path.AddArc(arc, 0, 90);
            arc.X = rectangle.Left;

            // Bottom-left corner
            path.AddArc(arc, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save Diary Entry";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the file path chosen by the user
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Write the contents of the TextBox to the chosen file
                    File.WriteAllText(filePath, Journal.Text);
                    MessageBox.Show("Diary entry saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving diary entry: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            SaveEntry();
        }

        private void SaveEntry()
        {
            // Prompt the user to choose a location to save the diary entry
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save Diary Entry";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the file path chosen by the user
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Write the contents of the TextBox to the chosen file
                    File.WriteAllText(filePath, Journal.Text);
                    MessageBox.Show("Diary entry saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving diary entry: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                this.ForeColor = colorDialog1.Color;
            }
        }

        private void FontColorMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()== DialogResult.OK)
            {
                Journal.ForeColor = colorDialog1.Color;
            }
        }

        private void FontStyleMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Journal.Font = fontDialog1.Font;
            }
        }

        private void textBoxColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Journal.BackColor = colorDialog1.Color;
            }
        }
    }
}
