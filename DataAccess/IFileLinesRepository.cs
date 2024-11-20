
namespace DataAccess
{
    //Интерфейс для работы с репозиторием
    public interface IFileLinesRepository
    {
        //Добавить строку
        Task AddAsync(FileLine fileLine);

        //Удалить все строки
        Task ClearAsync();
    }
}