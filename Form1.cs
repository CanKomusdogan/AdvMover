using System.Linq;

namespace AdvMover;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        MoveProgress.Minimum = 0;
        // Set max based on scenario
        MoveProgress.Step = 1;
        MoveProgress.Value = 0;
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

        if (FileExtensionsList.Items.Contains(input))
        {
            MessageBox.Show("You've already added this extension.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        FileExtensionsList.Items.Add(input);
        ExtensionInput.Text = string.Empty;
    }

    private void AddExtensionBtn_Click(object sender, EventArgs e) => AddExtension();

    private void ExtensionInput_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Return) AddExtension();
    }

    private void MoveFromSelectBtn_Click(object sender, EventArgs e)
    {
        try
        {
            MoveFrom.ShowDialog();
            FolderFromInput.Text = MoveFrom.SelectedPath;
        }
        finally
        {
            MoveFrom.Dispose();
        }
    }

    private void MoveToBtn_Click(object sender, EventArgs e)
    {
        try
        {
            MoveTo.ShowDialog();
            FolderToInput.Text = MoveTo.SelectedPath;
        }
        finally
        {
            MoveTo.Dispose();
        }
    }

    private void StartMove()
    {
        bool fromExists = Directory.Exists(FolderFromInput.Text);
        bool toExists = Directory.Exists(FolderToInput.Text);
        if (fromExists && toExists)
        {
            MoveProgress.Invoke(() => MoveProgress.Maximum = FileExtensionsList.Items.Count);

            HashSet<string> extensions = new(FileExtensionsList.Items.Cast<string>(), StringComparer.OrdinalIgnoreCase);

            foreach (string filePath in Directory.GetFiles(FolderFromInput.Text))
            {
                string fileExtension = Path.GetExtension(filePath);
                if (MoveAllCheckbox.Checked || extensions.Contains(fileExtension))
                {
                    string fileName = Path.GetFileName(filePath);
                    string destinationPath = Path.Combine(FolderToInput.Text, fileName);

                    Task.Run(() =>
                    {
                        try
                        {
                            File.Move(filePath, destinationPath, OverwriteCheckBox.Checked);
                            UpdateStatus(filePath, destinationPath);
                        }
                        catch (IOException ioex)
                        {
                            HandleIOException(ioex, fileName, destinationPath);
                        }
                    });

                    Thread.Sleep(50);
                }
            }

            StatusLabel.Invoke(() => StatusLabel.Text = string.Empty);
            MessageBox.Show("All done!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MoveProgress.Invoke(() => MoveProgress.Value = 0);
        }
        else
        {
            ShowFolderError(fromExists, toExists);
        }
    }

    private void HandleIOException(IOException ioex, string fileName, string destinationPath)
    {
        if (File.Exists(destinationPath))
        {
            StatusLabel.Invoke(() =>
            {
                StatusLabel.Text = $"{fileName} already exists at {destinationPath}. Ignoring and continuing...";
            });
        }
        else
        {
            StatusLabel.Invoke(() =>
            {
                MessageBox.Show($"An IO exception occurred: {ioex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            });
        }
    }

    private void ShowFolderError(bool fromExists, bool toExists)
    {
        if (!fromExists && !toExists)
        {
            MessageBox.Show("The selected folder to move from and the selected folder to move to doesn't exist.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else if (!toExists)
        {
            MessageBox.Show("The selected folder to move to doesn't exist.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else if (!fromExists)
        {
            MessageBox.Show("The selected folder to move from doesn't exist.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private void UpdateStatus(string filePath, string destinationPath)
    {
        StatusLabel.Invoke(() => StatusLabel.Text = $"Moved: {filePath} to {destinationPath}");
        MoveProgress.Invoke(() => MoveProgress.Increment(1));
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

    private void MoveAllCheckbox_CheckedChanged(object sender, EventArgs e) => ExtUI(!MoveAllCheckbox.Checked);

    private void RemoveExtensionBtn_Click(object sender, EventArgs e)
    {
        object? selectedItem = FileExtensionsList.SelectedItem;

        if (selectedItem == null)
        {
            MessageBox.Show("No item selected.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        FileExtensionsList.Items.Remove(selectedItem);
    }

    private string[] _mediaExts = { ".mp4", ".mp3", ".png", ".jpg", ".jpeg", ".mov", ".webm", ".webp", ".jfif", ".ogg", ".wav", ".raw", ".cr3", ".wmv", ".avi", ".m4a", ".mkv", ".wma", ".aac" };
    private void MediaPackButton_Click(object sender, EventArgs e)
    {
        HashSet<string> existingItems = FileExtensionsList.Items.Cast<string>().ToHashSet();

        foreach (string ext in _mediaExts)
        {
            if (!existingItems.Contains(ext))
            {
                FileExtensionsList.Items.Add(ext);
            }
        }
    }
}
