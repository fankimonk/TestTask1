using TestTask1.Generation;
using TestTask1.Import;
using TestTask1.Merging;

namespace TestTask1
{
    public partial class Form1 : Form
    {
        //Файлы для объединения
        private string[] _filesToMerge = [];

        //Файлы для импорта
        private string[] _filesToImport = [];

        private readonly FileLinesService _fileLinesService;

        public Form1()
        {
            InitializeComponent();
            _fileLinesService = new FileLinesService();
        }

        //Генерация файлов
        private async void GenerateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DirectoryPathTextBox.Text))
                MessageBox.Show("Choose directory", "Error", MessageBoxButtons.OK);

            if (!int.TryParse(FilesCountTextBox.Text, out int filesCount))
            {
                MessageBox.Show("Invalid files count", "Error", MessageBoxButtons.OK);
                return;
            }

            if (!int.TryParse(LinesCountTextBox.Text, out int rowsCount))
            {
                MessageBox.Show("Invalid rows count", "Error", MessageBoxButtons.OK);
                return;
            }

            IFilesGenerator generator = new FilesGenerator();
            var result = await generator.GenerateAsync(DirectoryPathTextBox.Text, filesCount, rowsCount);

            if (result == FilesGenerationResult.Success)
                MessageBox.Show("Files generated successfully", "Success");
            else
                MessageBox.Show("Failed to create files", "Failure");
        }

        //Выбор директории для генерации
        private void SelectDirectoryButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                DirectoryPathTextBox.Text = dialog.SelectedPath;
        }

        //Выбор файлов для объединения
        private void SelectFilesToMergeButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _filesToMerge = dialog.FileNames;
                SelectedFilesToMergeCountLabel.Text = "Selected files: " + _filesToMerge.Length.ToString();
            }
        }

        //Выбор результирующего файла для объединения
        private void SelectMergeOutputFileButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                MergeOutputFilePathTextBox.Text = dialog.FileName;
        }

        //Объединение файлов
        private async void MergeButton_Click(object sender, EventArgs e)
        {
            IFilesMerger filesMerger = new FilesMerger();
            var result = await filesMerger.MergeAsync(MergeOutputFilePathTextBox.Text, StringToRemoveTextBox.Text, _filesToMerge);
            if (result.Item1 != FilesMergeResult.Success)
            {
                MessageBox.Show("Failed to merge files", "Failure");
                return;
            }

            MessageBox.Show("Files merged successfully", "Success");
            RemovedLinesCountLabel.Text = "Removed lines: " + result.Item2;
            RemovedLinesCountLabel.Visible = true;
            _filesToMerge = [];
            SelectedFilesToMergeCountLabel.Text = "Selected files: " + _filesToMerge.Length.ToString();
        }

        //Импорт файлов
        private async void ImportButton_Click(object sender, EventArgs e)
        {
            ImportStatusLabel.Visible = true;
            IFilesImporter filesImporter = new FilesImporter();
            var progress = new Progress<FilesImportProgress>(value =>
            {
                ImportStatusLabel.Text = $"Lines imported: {value.LineProgress}\nLines left: {value.LinesLeft}";
            });

            var result = await filesImporter.ImportAsync(_filesToImport, progress);
            if (result == FilesImportResult.Failure)
            {
                MessageBox.Show("Failed to import files", "Failure");
                ImportStatusLabel.Text = "Failed to import files";
                return;
            }

            MessageBox.Show("Files imported successfully", "Success");
            _filesToImport = [];
            SelectedFilesToImportCountLabel.Text = "Selected files: " + _filesToImport.Length.ToString();
            ImportStatusLabel.Text = "All files were imported";
        }

        //Выбор файлов для импорта
        private void SelectFilesToImportButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _filesToImport = dialog.FileNames;
                SelectedFilesToImportCountLabel.Text = "Selected files: " + _filesToImport.Length.ToString();
            }
        }

        //Очистка таблицы БД
        private async void ClearDBTableButton_Click(object sender, EventArgs e)
        {
            await _fileLinesService.ClearAllImportedFiles();
            MessageBox.Show("All imported files were cleared", "Success");
        }

        //Вызов хранимой процедуры
        private async void ExecStoredProcedureButton_Click(object sender, EventArgs e)
        {
            var result = await StoredProcedureResult.ExecProcedure();
            StoredProcedureResultLabel.Visible = true;
            if (result == null)
            {
                StoredProcedureResultLabel.Text = "Failed to execute stored procedure";
                return;
            }

            StoredProcedureResultLabel.Text = $"Sum = {result.Sum.ToString()}; Median = {result.Median.ToString()}";
        }
    }
}
