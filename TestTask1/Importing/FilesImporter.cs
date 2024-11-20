using DataAccess;

namespace TestTask1.Import
{
    //Импортер файлов в таблицу
    public class FilesImporter : IFilesImporter
    {
        private readonly IFileLinesRepository _repository;

        public FilesImporter()
        {
            _repository = new FileLinesRepository();
        }

        //Импортирование файлов с путями filePaths
        public async Task<FilesImportResult> ImportAsync(string[] filePaths, 
            IProgress<FilesImportProgress> progress)
        {
            var filesImportProgress = new FilesImportProgress(GetLinesCount(filePaths));
            try
            {
                //Перебираем все файлы
                foreach (var filePath in filePaths)
                {
                    using StreamReader reader = new StreamReader(filePath);
                    string? line;

                    //Асинхронно читаем по одной линии из файла
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        //Создаем объект файла
                        var fileLine = FileLine.Parse(line);
                        if (fileLine == null) return FilesImportResult.Failure;

                        //Загружаем в БД
                        await _repository.AddAsync(fileLine);

                        filesImportProgress.IncreaseProgress();
                        progress.Report(filesImportProgress);
                    }
                }
            }
            catch (Exception)
            {
                return FilesImportResult.Failure;
            }


            return FilesImportResult.Success;
        }

        //Получение общего количества строк
        private long GetLinesCount(string[] filePaths)
        {
            var count = 0L;

            foreach (var filePath in filePaths)
            {
                using StreamReader reader = new(filePath);
                while (reader.ReadLine() != null)
                    count++;
            }

            return count;
        }
    }
}
