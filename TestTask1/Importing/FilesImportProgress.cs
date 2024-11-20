namespace TestTask1.Import
{
    //Прогресс загрузки файлов
    public class FilesImportProgress
    {
        public long LineProgress { get; private set; }
        public long LinesLeft { get; private set; }
        public long LinesTotal { get; private set; }

        public FilesImportProgress(long linesTotal)
        {
            LinesTotal = linesTotal;
            LineProgress = 0;
            LinesLeft = linesTotal;
        }

        public void IncreaseProgress()
        {
            LineProgress++;
            LinesLeft--;
        }
    }
}
