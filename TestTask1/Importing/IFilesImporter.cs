namespace TestTask1.Import
{
    //Интерфейс для работы с импортером
    public interface IFilesImporter
    {
        //Импорт файлов
        Task<FilesImportResult> ImportAsync(string[] filePaths, IProgress<FilesImportProgress> progress);
    }
}