namespace LogAn
{
    public class LogAnalyzer
    {
        private bool initialized = false;

        public void Initialize()
        {
            initialized = true;
        }

        public bool IsValid(string fileName)
        {
            if (!initialized)
            {
                throw new NotImplementedException("The analyzer .Initialize() method should be called before any other operation");
            }

            const int MinimumNameLength = 8;

            if (fileName.Length < MinimumNameLength)
            {
                return true;
            }

            return false;
        }
    }
}