using DataAccess;

namespace TestTask1
{
    //Сервис для работы с репозиторием
    public class FileLinesService
    {
        private readonly IFileLinesRepository _repository;

        public FileLinesService()
        {
            _repository = new FileLinesRepository();
        }

        public async Task ClearAllImportedFiles()
        {
            await _repository.ClearAsync();
        }
    }
}
