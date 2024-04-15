namespace LogAn
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException("filename has to be provided");
            }

            if (!fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }

            return true;
        }
    }
}