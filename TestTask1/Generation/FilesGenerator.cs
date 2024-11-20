using System.Text;

namespace TestTask1.Generation
{
    //Генератор файлов
    public class FilesGenerator : IFilesGenerator
    {
        //Алфавиты
        private const string _englishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private const string _russianAlphabet = "АБВГДЕЁЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзиклмнопрстуфхцчшщъыьэюя";

        private Random _random = new Random();

        //Генерация filesCount файлов c linesCount линиями в directoryPath
        public async Task<FilesGenerationResult> GenerateAsync(string directoryPath, int filesCount, int linesCount)
        {
            for (int i = 0; i < filesCount; i++)
            {
                string filePath = Path.Combine(directoryPath, $"file{i + 1}.txt");

                try
                {
                    await GenerateFileAsync(filePath, linesCount);
                }
                catch (Exception)
                {
                    return FilesGenerationResult.Failure;
                }
            }
            return FilesGenerationResult.Success;
        }

        //Генерация одного файла с linesCount линиями в filePath
        private async Task GenerateFileAsync(string filePath, int linesCount)
        {
            using StreamWriter writer = new StreamWriter(filePath);
            for (int i = 0; i < linesCount; i++)
            {
                var sb = new StringBuilder();
                sb.Append(GenerateDate());
                sb.Append("||");
                sb.Append(GenerateString(_englishAlphabet));
                sb.Append("||");
                sb.Append(GenerateString(_russianAlphabet));
                sb.Append("||");
                sb.Append(GenerateInteger());
                sb.Append("||");
                sb.Append(GenerateFloatingPointNumber());
                sb.Append("||");

                string lineContent = sb.ToString();
                await writer.WriteLineAsync(lineContent);
            }
        }

        //Генерация даты
        private string GenerateDate()
        {
            var startDate = new DateTime(2019, 1, 1);
            var daysRange = (DateTime.Today - startDate).Days;

            var generatedDate = startDate.AddDays(_random.Next(daysRange));
            return generatedDate.ToString("d");
        }

        //Генерация строки в зависимости от алфавита
        private string GenerateString(string alphabet)
        {
            const int n = 10;

            var sb = new StringBuilder(n);

            for (int i = 0; i < n; i++)
                sb.Append(alphabet[_random.Next(alphabet.Length)]);

            return sb.ToString();
        }

        //Генерация целого числа
        private string GenerateInteger() => _random.Next(1, 100000001).ToString();


        //Генерация числа с плавающей точкой
        private string GenerateFloatingPointNumber() => (_random.NextDouble() * 19 + 1).ToString("F8");

    }
}
