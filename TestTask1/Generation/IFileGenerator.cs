namespace TestTask1.Generation
{
    //Интерфейс для работы с генератором файлов
    public interface IFilesGenerator
    {
        //Генерация файлов
        Task<FilesGenerationResult> GenerateAsync(string directoryPath, int filesCount, int rowsCount);
    }
}
