using System.Security.AccessControl;

namespace AdvMover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddExtension()
        {
            string input = ExtensionInput.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Input can't be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!input.StartsWith('.'))
            {
                input = "." + input;
            }

            FileExtensionsList.Items.Add(input);
            ExtensionInput.Text = string.Empty;
        }

        private void AddExtensionBtn_Click(object sender, EventArgs e)
        {
            AddExtension();
        }

        private void ExtensionInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) AddExtension();
        }

        private void MoveFromSelectBtn_Click(object sender, EventArgs e)
        {
            MoveFrom.ShowDialog();
            FolderFromInput.Text = MoveFrom.SelectedPath;
            MoveFrom.Dispose();
        }

        private void MoveToBtn_Click(object sender, EventArgs e)
        {
            MoveTo.ShowDialog();
            FolderToInput.Text = MoveTo.SelectedPath;
            MoveTo.Dispose();
        }

        private void StartMove()
        {
            bool fromExists = Directory.Exists(FolderFromInput.Text);
            bool toExists = Directory.Exists(FolderToInput.Text);
            if (fromExists && toExists)
            {
                foreach (string filePath in Directory.GetFiles(FolderFromInput.Text))
                {
                    string fileExtension = Path.GetExtension(filePath);

                    HashSet<string> extensions = new(FileExtensionsList.Items.Cast<string>(), StringComparer.OrdinalIgnoreCase);

                    if (extensions.Contains(fileExtension))
                    {
                        string fileName = Path.GetFileName(filePath);
                        string destinationPath = Path.Combine(FolderToInput.Text, fileName);

                        File.Move(filePath, destinationPath, OverwriteCheckBox.Checked);
                        StatusLabel.Text = $"Moved: {filePath} to {destinationPath}";
                    }
                }

                StatusLabel.Text = string.Empty;
                MessageBox.Show("All done!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!fromExists && !toExists)
                {
                    MessageBox.Show("The selected folder to move from and the selected folder to move to doesn't exist.");
                }
                else if (!toExists)
                {
                    MessageBox.Show("The selected folder to move to doesn't exist.");
                }
                else if (!fromExists)
                {
                    MessageBox.Show("The selected folder to move from doesn't exist.");
                }
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Thread taskThread = new(StartMove);
            taskThread.Start();
        }


        private void ExtUI(bool enabled)
        {
            ExtensionInput.Enabled = enabled;
            AddExtensionBtn.Enabled = enabled;
            FileExtensionsList.Enabled = enabled;
        }

        private void MoveAllCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ExtUI(!MoveAllCheckbox.Checked);
        }
    }
}
