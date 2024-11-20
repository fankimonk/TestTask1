using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    //Репозиторий для работы с таблицей строк
    public class FileLinesRepository : IFileLinesRepository
    {
        private readonly TestTask1DBContext _dbContext;

        public FileLinesRepository()
        {
            _dbContext = new TestTask1DBContext();
        }

        //Добавление строки в таблицу
        public async Task AddAsync(FileLine fileLine)
        {
            if (fileLine == null) throw new ArgumentException(nameof(fileLine));
            await _dbContext.FileLines.AddAsync(fileLine);
            await _dbContext.SaveChangesAsync();
        }

        //Удаление всех строк из таблицы
        public async Task ClearAsync()
        {
            await _dbContext.FileLines.Where(fl => fl.Id > 0).ExecuteDeleteAsync();
            await _dbContext.SaveChangesAsync();
        }
    }
}
