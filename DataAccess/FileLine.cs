using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess
{
    public class FileLine //Модель для загрузки данных в таблицу БД
    {
        //Значения для проверки валидности строки
        private static readonly DateTime _minDate = new DateTime(2019, 1, 1);
        private const int _stringLength = 10;
        private const int _integerLowerBound = 1;
        private const int _integerUpperBound = 100000000;
        private const int _floatingPointNumberLowerBound = 1;
        private const int _floatingPointNumberUpperBound = 20;

        //Столбцы таблицы
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public string LatinString { get; set; } = string.Empty;
        public string RussianString { get; set; } = string.Empty;

        public int Integer { get; set; }

        [Column(TypeName = "decimal(18,8)")] 
        public decimal FloatingPointNumber { get; set; }

        private FileLine(DateTime date, string latinString, string russianString, int integer, decimal floatingPointNumber)
        {
            Date = date;
            LatinString = latinString;
            RussianString = russianString;
            Integer = integer;
            FloatingPointNumber = floatingPointNumber;
        }

        //Создание объекта строки с валидацией
        public static FileLine? Create(DateTime date, string latinString, string russianString, int integer, decimal floatingPointNumber)
        {
            if (date < _minDate) return null;
            if (latinString.Length != _stringLength) return null;
            if (russianString.Length != _stringLength) return null;
            if (integer < _integerLowerBound) return null;
            if (integer > _integerUpperBound) return null;
            if (floatingPointNumber < _floatingPointNumberLowerBound) return null;
            if (floatingPointNumber > _floatingPointNumberUpperBound) return null;

            return new FileLine(date, latinString, russianString, integer, floatingPointNumber);
        }

        //Парсинг объекта строки из текста
        public static FileLine? Parse(string line)
        {
            var fields = line.Split("||", StringSplitOptions.RemoveEmptyEntries);

            if (!DateTime.TryParse(fields[0], out var date)) return null;
            if (!int.TryParse(fields[3], out var integer)) return null;
            if (!decimal.TryParse(fields[4], out var floatingPointNumber)) return null;

            return Create(date, fields[1], fields[2], integer, floatingPointNumber);
        }
    }
}
