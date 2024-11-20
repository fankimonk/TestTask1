namespace TestTask1.Merging
{
    //Объединитель файлов
    public class FilesMerger : IFilesMerger
    {
        //Объеденить файлы inputFilesPaths в outputFilePath с удаленмем stringToRemove
        public async Task<(FilesMergeResult, int)> MergeAsync(string outputFilePath, string stringToRemove, string[] inputFilesPaths)
        {
            int removedLinesCount = 0;
            try
            {
                using StreamWriter writer = new StreamWriter(outputFilePath);
                foreach (var filePath in inputFilesPaths)
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string? line;
                        while ((line = await reader.ReadLineAsync()) != null)
                        {
                            if (line.Contains(stringToRemove))
                            {
                                removedLinesCount++;
                                continue;
                            }
                            await writer.WriteLineAsync(line);
                        }
                    }
                    //Удаление файла, содержимое которого было объединено с результирующим файлом
                    File.Delete(filePath);
                }
            }
            catch (Exception)
            {
                return (FilesMergeResult.Failure, -1);
            }

            return (FilesMergeResult.Success, removedLinesCount);
        }
    }
}
