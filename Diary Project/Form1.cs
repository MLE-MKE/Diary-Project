using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Form1()
        {
            InitializeComponent();
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

            // Check if the TextBox is empty
            if (Journal.Text != "")
            {
                // Ask the user if they want to save the current entry
                DialogResult result = MessageBox.Show("Do you want to save the current entry before starting a new one?", "Save Entry", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Save the current entry
                    SaveEntry();
                }
                else if (result == DialogResult.Cancel)
                {
                    // If the user cancels, return without clearing the TextBox
                    return;
                }
            }

            // Clear the TextBox to start a new diary entry
            Journal.Clear();
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


    }
}
