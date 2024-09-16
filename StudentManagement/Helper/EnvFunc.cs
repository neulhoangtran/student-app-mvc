using System;
using DotNetEnv;
namespace StudentManagement.Helper
{
    public static class EnvFunc
    {

        public static string GetRootDirectory()
        {
            // Lấy thư mục hiện tại (bin\Debug)
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public static void LoadEnv()
        {
            // Nạp biến môi trường từ file .env với đường dẫn cụ thể
            string envFilePath = getEnvFile();

            // Kiểm tra file tồn tại trước khi nạp
            if (File.Exists(envFilePath))
            {
                Env.Load(envFilePath);
            }
        }


        public static bool ConfigFileExists()
        {
            // Lấy đường dẫn tuyệt đối đến file .env
            string rootDirectory = GetRootDirectory();
            string fileName = ".env";
            string fullPath = Path.Combine(rootDirectory, fileName);
            //MessageBox.Show(fullPath);
            return System.IO.File.Exists(fullPath);
        }


        public static string getEnvFile()
        {
            string rootDirectory = GetRootDirectory();
            string fileName = ".env";
            return Path.Combine(rootDirectory, fileName);
        }

        public async static Task<bool> SaveConnectionInfoToEnv(string dbHost, string dbDatabase)
        {
            try
            {

                string envFilePath = getEnvFile();
                var envContents = new List<string>();

                // Đọc nội dung hiện tại của file .env nếu tồn tại
                if (File.Exists(envFilePath))
                {
                    envContents = File.ReadAllLines(envFilePath).ToList();
                }

                // Kiểm tra và cập nhật hoặc thêm DB_HOST
                bool dbHostExists = false;
                for (int i = 0; i < envContents.Count; i++)
                {
                    if (envContents[i].StartsWith("DB_HOST="))
                    {
                        envContents[i] = $"DB_HOST={dbHost}";
                        dbHostExists = true;
                        break;
                    }
                }
                if (!dbHostExists)
                {
                    envContents.Add($"DB_HOST={dbHost}");
                }

                // Kiểm tra và cập nhật hoặc thêm DB_DATABASE
                bool dbDatabaseExists = false;
                for (int i = 0; i < envContents.Count; i++)
                {
                    if (envContents[i].StartsWith("DB_DATABASE="))
                    {
                        envContents[i] = $"DB_DATABASE={dbDatabase}";
                        dbDatabaseExists = true;
                        break;
                    }
                }
                if (!dbDatabaseExists)
                {
                    envContents.Add($"DB_DATABASE={dbDatabase}");
                }

                //MessageBox.Show(envFilePath);
                //MessageBox.Show(string.Join(Environment.NewLine, envContents));

                // Ghi lại nội dung vào file .env
                File.WriteAllLines(envFilePath, envContents);

                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool CheckEnvRequireValue()
        {
            // Tải các biến môi trường từ file .env
            LoadEnv();

            // Lấy giá trị của các biến môi trường
            string dbHost = Environment.GetEnvironmentVariable("DB_HOST");
            string dbDatabase = Environment.GetEnvironmentVariable("DB_DATABASE");

            // Kiểm tra các biến môi trường có giá trị không
            if (string.IsNullOrEmpty(dbHost))
            {
                //Console.WriteLine("Thiếu giá trị DB_HOST.");
                return false;
            }

            if (string.IsNullOrEmpty(dbDatabase))
            {
                //Console.WriteLine("Thiếu giá trị DB_DATABASE.");
                return false;
            }

            // Nếu tất cả các biến đều có giá trị, trả về true
            return true;
        }
    }
}
