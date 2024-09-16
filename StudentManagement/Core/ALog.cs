namespace StudentManagement.Core
{
    public abstract class ALog 
    {
        private readonly string LogDir = @"C:\Log";
        private readonly string LogFile ;
        public ALog()
        {
            if (!Directory.Exists(LogDir))
            {
                try
                {
                    Directory.CreateDirectory(LogDir);
                    using (File.Create(LogFile)) { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't create Log file.");
                }
            }
        }

        // Method to write a log message to the file
        public void WriteLog(string level, string message)
        {
            string formattedMessage = FormatMessage(level, message);
            try
            {
                File.AppendAllText(LogFile, formattedMessage + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to write log: {ex.Message}");
            }
        }

        // Format the log message with timestamp and level
        protected string FormatMessage(string level, string message)
        {
            return $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";
        }
    }
}