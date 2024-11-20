namespace TestTask1
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
            GenerateButton = new Button();
            DirectoryPathTextBox = new TextBox();
            DirectoryPathLabel = new Label();
            SelectDirectoryButton = new Button();
            FilesCountLabel = new Label();
            FilesCountTextBox = new TextBox();
            LinesCountTextBox = new TextBox();
            LinesCountLabel = new Label();
            SelectFilesToMergeButton = new Button();
            SelectedFilesToMergeCountLabel = new Label();
            MergeButton = new Button();
            SelectMergeOutputFileButton = new Button();
            MergeOutputFilePathTextBox = new TextBox();
            StringToRemoveTextBox = new TextBox();
            StringToRemoveLabel = new Label();
            RemovedLinesCountLabel = new Label();
            SelectFilesToImportButton = new Button();
            SelectedFilesToImportCountLabel = new Label();
            ImportButton = new Button();
            ImportStatusLabel = new Label();
            ClearDBTableButton = new Button();
            ExecStoredProcedureButton = new Button();
            StoredProcedureResultLabel = new Label();
            SuspendLayout();
            // 
            // GenerateButton
            // 
            GenerateButton.Location = new Point(12, 114);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(123, 23);
            GenerateButton.TabIndex = 0;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // DirectoryPathTextBox
            // 
            DirectoryPathTextBox.Location = new Point(12, 27);
            DirectoryPathTextBox.Name = "DirectoryPathTextBox";
            DirectoryPathTextBox.ReadOnly = true;
            DirectoryPathTextBox.Size = new Size(181, 23);
            DirectoryPathTextBox.TabIndex = 1;
            // 
            // DirectoryPathLabel
            // 
            DirectoryPathLabel.AutoSize = true;
            DirectoryPathLabel.Location = new Point(12, 9);
            DirectoryPathLabel.Name = "DirectoryPathLabel";
            DirectoryPathLabel.Size = new Size(82, 15);
            DirectoryPathLabel.TabIndex = 2;
            DirectoryPathLabel.Text = "Directory path";
            // 
            // SelectDirectoryButton
            // 
            SelectDirectoryButton.Location = new Point(199, 27);
            SelectDirectoryButton.Name = "SelectDirectoryButton";
            SelectDirectoryButton.Size = new Size(26, 23);
            SelectDirectoryButton.TabIndex = 3;
            SelectDirectoryButton.Text = "...";
            SelectDirectoryButton.UseVisualStyleBackColor = true;
            SelectDirectoryButton.Click += SelectDirectoryButton_Click;
            // 
            // FilesCountLabel
            // 
            FilesCountLabel.AutoSize = true;
            FilesCountLabel.Location = new Point(12, 59);
            FilesCountLabel.Name = "FilesCountLabel";
            FilesCountLabel.Size = new Size(64, 15);
            FilesCountLabel.TabIndex = 5;
            FilesCountLabel.Text = "Files count";
            // 
            // FilesCountTextBox
            // 
            FilesCountTextBox.Location = new Point(87, 56);
            FilesCountTextBox.Name = "FilesCountTextBox";
            FilesCountTextBox.Size = new Size(48, 23);
            FilesCountTextBox.TabIndex = 6;
            FilesCountTextBox.Text = "100";
            // 
            // LinesCountTextBox
            // 
            LinesCountTextBox.Location = new Point(87, 85);
            LinesCountTextBox.Name = "LinesCountTextBox";
            LinesCountTextBox.Size = new Size(48, 23);
            LinesCountTextBox.TabIndex = 8;
            LinesCountTextBox.Text = "100000";
            // 
            // LinesCountLabel
            // 
            LinesCountLabel.AutoSize = true;
            LinesCountLabel.Location = new Point(12, 88);
            LinesCountLabel.Name = "LinesCountLabel";
            LinesCountLabel.Size = new Size(68, 15);
            LinesCountLabel.TabIndex = 7;
            LinesCountLabel.Text = "Lines count";
            // 
            // SelectFilesToMergeButton
            // 
            SelectFilesToMergeButton.Location = new Point(281, 56);
            SelectFilesToMergeButton.Name = "SelectFilesToMergeButton";
            SelectFilesToMergeButton.Size = new Size(141, 23);
            SelectFilesToMergeButton.TabIndex = 9;
            SelectFilesToMergeButton.Text = "Select files to merge";
            SelectFilesToMergeButton.UseVisualStyleBackColor = true;
            SelectFilesToMergeButton.Click += SelectFilesToMergeButton_Click;
            // 
            // SelectedFilesToMergeCountLabel
            // 
            SelectedFilesToMergeCountLabel.AutoSize = true;
            SelectedFilesToMergeCountLabel.Location = new Point(428, 60);
            SelectedFilesToMergeCountLabel.Name = "SelectedFilesToMergeCountLabel";
            SelectedFilesToMergeCountLabel.Size = new Size(81, 15);
            SelectedFilesToMergeCountLabel.TabIndex = 10;
            SelectedFilesToMergeCountLabel.Text = "Selected files: ";
            // 
            // MergeButton
            // 
            MergeButton.Location = new Point(281, 117);
            MergeButton.Name = "MergeButton";
            MergeButton.Size = new Size(141, 23);
            MergeButton.TabIndex = 11;
            MergeButton.Text = "Merge";
            MergeButton.UseVisualStyleBackColor = true;
            MergeButton.Click += MergeButton_Click;
            // 
            // SelectMergeOutputFileButton
            // 
            SelectMergeOutputFileButton.Location = new Point(468, 27);
            SelectMergeOutputFileButton.Name = "SelectMergeOutputFileButton";
            SelectMergeOutputFileButton.Size = new Size(26, 23);
            SelectMergeOutputFileButton.TabIndex = 13;
            SelectMergeOutputFileButton.Text = "...";
            SelectMergeOutputFileButton.UseVisualStyleBackColor = true;
            SelectMergeOutputFileButton.Click += SelectMergeOutputFileButton_Click;
            // 
            // MergeOutputFilePathTextBox
            // 
            MergeOutputFilePathTextBox.Location = new Point(281, 27);
            MergeOutputFilePathTextBox.Name = "MergeOutputFilePathTextBox";
            MergeOutputFilePathTextBox.ReadOnly = true;
            MergeOutputFilePathTextBox.Size = new Size(181, 23);
            MergeOutputFilePathTextBox.TabIndex = 12;
            // 
            // StringToRemoveTextBox
            // 
            StringToRemoveTextBox.Location = new Point(382, 88);
            StringToRemoveTextBox.Name = "StringToRemoveTextBox";
            StringToRemoveTextBox.Size = new Size(112, 23);
            StringToRemoveTextBox.TabIndex = 14;
            // 
            // StringToRemoveLabel
            // 
            StringToRemoveLabel.AutoSize = true;
            StringToRemoveLabel.Location = new Point(281, 91);
            StringToRemoveLabel.Name = "StringToRemoveLabel";
            StringToRemoveLabel.Size = new Size(95, 15);
            StringToRemoveLabel.TabIndex = 15;
            StringToRemoveLabel.Text = "String to remove";
            // 
            // RemovedLinesCountLabel
            // 
            RemovedLinesCountLabel.AutoSize = true;
            RemovedLinesCountLabel.Location = new Point(281, 143);
            RemovedLinesCountLabel.Name = "RemovedLinesCountLabel";
            RemovedLinesCountLabel.Size = new Size(90, 15);
            RemovedLinesCountLabel.TabIndex = 16;
            RemovedLinesCountLabel.Text = "Removed lines: ";
            RemovedLinesCountLabel.Visible = false;
            // 
            // SelectFilesToImportButton
            // 
            SelectFilesToImportButton.Location = new Point(12, 206);
            SelectFilesToImportButton.Name = "SelectFilesToImportButton";
            SelectFilesToImportButton.Size = new Size(230, 23);
            SelectFilesToImportButton.TabIndex = 17;
            SelectFilesToImportButton.Text = "Select files to import to database";
            SelectFilesToImportButton.UseVisualStyleBackColor = true;
            SelectFilesToImportButton.Click += SelectFilesToImportButton_Click;
            // 
            // SelectedFilesToImportCountLabel
            // 
            SelectedFilesToImportCountLabel.AutoSize = true;
            SelectedFilesToImportCountLabel.Location = new Point(248, 210);
            SelectedFilesToImportCountLabel.Name = "SelectedFilesToImportCountLabel";
            SelectedFilesToImportCountLabel.Size = new Size(81, 15);
            SelectedFilesToImportCountLabel.TabIndex = 18;
            SelectedFilesToImportCountLabel.Text = "Selected files: ";
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(12, 235);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(123, 23);
            ImportButton.TabIndex = 19;
            ImportButton.Text = "Import";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // ImportStatusLabel
            // 
            ImportStatusLabel.AutoSize = true;
            ImportStatusLabel.Location = new Point(141, 239);
            ImportStatusLabel.Name = "ImportStatusLabel";
            ImportStatusLabel.Size = new Size(77, 15);
            ImportStatusLabel.TabIndex = 20;
            ImportStatusLabel.Text = "Import status";
            ImportStatusLabel.Visible = false;
            // 
            // ClearDBTableButton
            // 
            ClearDBTableButton.Location = new Point(12, 264);
            ClearDBTableButton.Name = "ClearDBTableButton";
            ClearDBTableButton.Size = new Size(123, 23);
            ClearDBTableButton.TabIndex = 21;
            ClearDBTableButton.Text = "Clear DB Table";
            ClearDBTableButton.UseVisualStyleBackColor = true;
            ClearDBTableButton.Click += ClearDBTableButton_Click;
            // 
            // ExecStoredProcedureButton
            // 
            ExecStoredProcedureButton.Location = new Point(12, 340);
            ExecStoredProcedureButton.Name = "ExecStoredProcedureButton";
            ExecStoredProcedureButton.Size = new Size(181, 23);
            ExecStoredProcedureButton.TabIndex = 22;
            ExecStoredProcedureButton.Text = "Execute Stored Procedure";
            ExecStoredProcedureButton.UseVisualStyleBackColor = true;
            ExecStoredProcedureButton.Click += ExecStoredProcedureButton_Click;
            // 
            // StoredProcedureResultLabel
            // 
            StoredProcedureResultLabel.AutoSize = true;
            StoredProcedureResultLabel.Location = new Point(199, 344);
            StoredProcedureResultLabel.Name = "StoredProcedureResultLabel";
            StoredProcedureResultLabel.Size = new Size(83, 15);
            StoredProcedureResultLabel.TabIndex = 23;
            StoredProcedureResultLabel.Text = "Sum: Median: ";
            StoredProcedureResultLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 373);
            Controls.Add(StoredProcedureResultLabel);
            Controls.Add(ExecStoredProcedureButton);
            Controls.Add(ClearDBTableButton);
            Controls.Add(ImportStatusLabel);
            Controls.Add(ImportButton);
            Controls.Add(SelectedFilesToImportCountLabel);
            Controls.Add(SelectFilesToImportButton);
            Controls.Add(RemovedLinesCountLabel);
            Controls.Add(StringToRemoveLabel);
            Controls.Add(StringToRemoveTextBox);
            Controls.Add(SelectMergeOutputFileButton);
            Controls.Add(MergeOutputFilePathTextBox);
            Controls.Add(MergeButton);
            Controls.Add(SelectedFilesToMergeCountLabel);
            Controls.Add(SelectFilesToMergeButton);
            Controls.Add(LinesCountTextBox);
            Controls.Add(LinesCountLabel);
            Controls.Add(FilesCountTextBox);
            Controls.Add(FilesCountLabel);
            Controls.Add(SelectDirectoryButton);
            Controls.Add(DirectoryPathLabel);
            Controls.Add(DirectoryPathTextBox);
            Controls.Add(GenerateButton);
            Name = "Form1";
            Text = "TestTask1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerateButton;
        private TextBox DirectoryPathTextBox;
        private Label DirectoryPathLabel;
        private Button SelectDirectoryButton;
        private Label FilesCountLabel;
        private TextBox FilesCountTextBox;
        private TextBox LinesCountTextBox;
        private Label LinesCountLabel;
        private Button SelectFilesToMergeButton;
        private Label SelectedFilesToMergeCountLabel;
        private Button MergeButton;
        private Button SelectMergeOutputFileButton;
        private TextBox MergeOutputFilePathTextBox;
        private TextBox StringToRemoveTextBox;
        private Label StringToRemoveLabel;
        private Label RemovedLinesCountLabel;
        private Button SelectFilesToImportButton;
        private Label SelectedFilesToImportCountLabel;
        private Button ImportButton;
        private Label ImportStatusLabel;
        private Button ClearDBTableButton;
        private Button ExecStoredProcedureButton;
        private Label StoredProcedureResultLabel;
    }
}
