namespace TestTask1.Merging
{
    //Интерфейс для работы с объеденителем
    public interface IFilesMerger
    {
        //Объеденить файлы
        Task<(FilesMergeResult, int)> MergeAsync(string outputFilePath, string stringToRemove, string[] inputFilesPaths);
    }
}
