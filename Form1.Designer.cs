namespace AdvMover
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            FileExtensionsList = new ListBox();
            ExtensionInput = new TextBox();
            SubmitBtn = new Button();
            MoveTo = new FolderBrowserDialog();
            MoveFrom = new FolderBrowserDialog();
            AddExtensionBtn = new Button();
            groupBox1 = new GroupBox();
            RemoveExtensionBtn = new Button();
            MoveAllCheckbox = new CheckBox();
            groupBox2 = new GroupBox();
            FolderFromInput = new TextBox();
            MoveFromSelectBtn = new Button();
            groupBox3 = new GroupBox();
            FolderToInput = new TextBox();
            MoveToBtn = new Button();
            groupBox4 = new GroupBox();
            OverwriteCheckBox = new CheckBox();
            StatusLabel = new Label();
            MoveProgress = new ProgressBar();
            MediaPackButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(23, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 80);
            label1.TabIndex = 0;
            label1.Text = "Specify the file extensions";
            // 
            // FileExtensionsList
            // 
            FileExtensionsList.FormattingEnabled = true;
            FileExtensionsList.ItemHeight = 15;
            FileExtensionsList.Location = new Point(23, 214);
            FileExtensionsList.Margin = new Padding(4, 3, 4, 3);
            FileExtensionsList.Name = "FileExtensionsList";
            FileExtensionsList.Size = new Size(246, 124);
            FileExtensionsList.TabIndex = 1;
            // 
            // ExtensionInput
            // 
            ExtensionInput.Location = new Point(28, 112);
            ExtensionInput.Margin = new Padding(4, 3, 4, 3);
            ExtensionInput.Name = "ExtensionInput";
            ExtensionInput.Size = new Size(246, 21);
            ExtensionInput.TabIndex = 2;
            ExtensionInput.KeyPress += ExtensionInput_KeyPress;
            // 
            // SubmitBtn
            // 
            SubmitBtn.ForeColor = Color.FromArgb(48, 48, 48);
            SubmitBtn.Location = new Point(475, 489);
            SubmitBtn.Margin = new Padding(4, 3, 4, 3);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(228, 58);
            SubmitBtn.TabIndex = 3;
            SubmitBtn.Text = "Do It!";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // AddExtensionBtn
            // 
            AddExtensionBtn.ForeColor = Color.FromArgb(48, 48, 48);
            AddExtensionBtn.Location = new Point(28, 149);
            AddExtensionBtn.Margin = new Padding(4, 3, 4, 3);
            AddExtensionBtn.Name = "AddExtensionBtn";
            AddExtensionBtn.Size = new Size(96, 31);
            AddExtensionBtn.TabIndex = 4;
            AddExtensionBtn.Text = "Add";
            AddExtensionBtn.UseVisualStyleBackColor = true;
            AddExtensionBtn.Click += AddExtensionBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MediaPackButton);
            groupBox1.Controls.Add(RemoveExtensionBtn);
            groupBox1.Controls.Add(MoveAllCheckbox);
            groupBox1.Controls.Add(ExtensionInput);
            groupBox1.Controls.Add(AddExtensionBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FileExtensionsList);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(65, 12);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(325, 389);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ext";
            // 
            // RemoveExtensionBtn
            // 
            RemoveExtensionBtn.ForeColor = Color.FromArgb(48, 48, 48);
            RemoveExtensionBtn.Location = new Point(173, 149);
            RemoveExtensionBtn.Margin = new Padding(4, 3, 4, 3);
            RemoveExtensionBtn.Name = "RemoveExtensionBtn";
            RemoveExtensionBtn.Size = new Size(96, 31);
            RemoveExtensionBtn.TabIndex = 6;
            RemoveExtensionBtn.Text = "Remove";
            RemoveExtensionBtn.UseVisualStyleBackColor = true;
            RemoveExtensionBtn.Click += RemoveExtensionBtn_Click;
            // 
            // MoveAllCheckbox
            // 
            MoveAllCheckbox.AutoSize = true;
            MoveAllCheckbox.Location = new Point(28, 349);
            MoveAllCheckbox.Margin = new Padding(4, 3, 4, 3);
            MoveAllCheckbox.Name = "MoveAllCheckbox";
            MoveAllCheckbox.Size = new Size(72, 19);
            MoveAllCheckbox.TabIndex = 5;
            MoveAllCheckbox.Text = "Move All";
            MoveAllCheckbox.UseVisualStyleBackColor = true;
            MoveAllCheckbox.CheckedChanged += MoveAllCheckbox_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(FolderFromInput);
            groupBox2.Controls.Add(MoveFromSelectBtn);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(65, 407);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(325, 170);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select the folder to move from";
            // 
            // FolderFromInput
            // 
            FolderFromInput.Location = new Point(7, 96);
            FolderFromInput.Margin = new Padding(4, 3, 4, 3);
            FolderFromInput.Name = "FolderFromInput";
            FolderFromInput.ReadOnly = true;
            FolderFromInput.Size = new Size(310, 21);
            FolderFromInput.TabIndex = 8;
            // 
            // MoveFromSelectBtn
            // 
            MoveFromSelectBtn.ForeColor = Color.FromArgb(48, 48, 48);
            MoveFromSelectBtn.Location = new Point(28, 40);
            MoveFromSelectBtn.Margin = new Padding(4, 3, 4, 3);
            MoveFromSelectBtn.Name = "MoveFromSelectBtn";
            MoveFromSelectBtn.Size = new Size(134, 34);
            MoveFromSelectBtn.TabIndex = 7;
            MoveFromSelectBtn.Text = "Select";
            MoveFromSelectBtn.UseVisualStyleBackColor = true;
            MoveFromSelectBtn.Click += MoveFromSelectBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(FolderToInput);
            groupBox3.Controls.Add(MoveToBtn);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(781, 407);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(360, 170);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Select the folder to move to";
            // 
            // FolderToInput
            // 
            FolderToInput.Location = new Point(7, 89);
            FolderToInput.Margin = new Padding(4, 3, 4, 3);
            FolderToInput.Name = "FolderToInput";
            FolderToInput.ReadOnly = true;
            FolderToInput.Size = new Size(345, 21);
            FolderToInput.TabIndex = 11;
            // 
            // MoveToBtn
            // 
            MoveToBtn.ForeColor = Color.FromArgb(48, 48, 48);
            MoveToBtn.Location = new Point(24, 40);
            MoveToBtn.Margin = new Padding(4, 3, 4, 3);
            MoveToBtn.Name = "MoveToBtn";
            MoveToBtn.Size = new Size(134, 34);
            MoveToBtn.TabIndex = 10;
            MoveToBtn.Text = "Select";
            MoveToBtn.UseVisualStyleBackColor = true;
            MoveToBtn.Click += MoveToBtn_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(OverwriteCheckBox);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(781, 249);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(360, 152);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Settings";
            // 
            // OverwriteCheckBox
            // 
            OverwriteCheckBox.AutoSize = true;
            OverwriteCheckBox.Location = new Point(24, 35);
            OverwriteCheckBox.Margin = new Padding(4, 3, 4, 3);
            OverwriteCheckBox.Name = "OverwriteCheckBox";
            OverwriteCheckBox.Size = new Size(147, 19);
            OverwriteCheckBox.TabIndex = 0;
            OverwriteCheckBox.Text = "Overwrite existing files";
            OverwriteCheckBox.UseVisualStyleBackColor = true;
            // 
            // StatusLabel
            // 
            StatusLabel.Font = new Font("Segoe UI", 12F);
            StatusLabel.Location = new Point(419, 9);
            StatusLabel.Margin = new Padding(4, 0, 4, 0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(722, 234);
            StatusLabel.TabIndex = 10;
            StatusLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // MoveProgress
            // 
            MoveProgress.Location = new Point(419, 575);
            MoveProgress.Margin = new Padding(4, 3, 4, 3);
            MoveProgress.Name = "MoveProgress";
            MoveProgress.Size = new Size(337, 34);
            MoveProgress.TabIndex = 11;
            // 
            // MediaPackButton
            // 
            MediaPackButton.ForeColor = Color.FromArgb(48, 48, 48);
            MediaPackButton.Location = new Point(180, 346);
            MediaPackButton.Name = "MediaPackButton";
            MediaPackButton.Size = new Size(89, 23);
            MediaPackButton.TabIndex = 7;
            MediaPackButton.Text = "MediaPack";
            MediaPackButton.UseVisualStyleBackColor = true;
            MediaPackButton.Click += MediaPackButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(1200, 621);
            Controls.Add(MoveProgress);
            Controls.Add(StatusLabel);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(SubmitBtn);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdvMover";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListBox FileExtensionsList;
        private TextBox ExtensionInput;
        private Button SubmitBtn;
        private FolderBrowserDialog MoveTo;
        private FolderBrowserDialog MoveFrom;
        private Button AddExtensionBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox FolderFromInput;
        private Button MoveFromSelectBtn;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox FolderToInput;
        private Button MoveToBtn;
        private Label StatusLabel;
        private ProgressBar MoveProgress;
        private CheckBox OverwriteCheckBox;
        private CheckBox MoveAllCheckbox;
        private Button RemoveExtensionBtn;
        private Button MediaPackButton;
    }
}
