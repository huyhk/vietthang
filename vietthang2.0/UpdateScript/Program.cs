using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace UpdateScript
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory; // e.g., "C:\YourApp\bin\Debug\" [1]

            var conFile = Path.Combine(baseDirectory,"VES.exe.config");

            var server = GetAppSettingFromExternalConfig(conFile, "Server");
            var db = GetAppSettingFromExternalConfig(conFile, "Database");
            var userName = GetAppSettingFromExternalConfig(conFile, "UserName");
            var pass = GetAppSettingFromExternalConfig(conFile, "Password");
            pass = VNS.Security.Crypto.DecryptString(pass);
            var conString = BuildSqlConnectionString(server, db, userName, pass);

            Console.WriteLine("reading script file ...");

            var scriptFile = Path.Combine(baseDirectory,"Script.sql");
            var scriptContent = ReadContent(scriptFile);
            string[] batches = Regex.Split(
                   scriptContent,
                    @"(?:\r?\n\s*GO\s*\r?\n)|(?:^\s*GO\s*\r?\n)|(?:\r?\n\s*GO\s*$)",
                   RegexOptions.Multiline | RegexOptions.IgnoreCase
               );


                Console.WriteLine("updating database ...");
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();

                    // 2. Use a transaction to ensure all batches succeed or all fail
                    using (SqlTransaction trans = conn.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.Transaction = trans;
                            cmd.CommandTimeout = 60; // Increase timeout for long-running scripts (e.g., table creation)

                            try
                            {
                                foreach (string batch in batches)
                                {
                                    string cleanBatch = batch.Trim();
                                    //Console.WriteLine(cleanBatch);


                                    // Skip empty chunks caused by multiple consecutive GO lines
                                    if (!string.IsNullOrEmpty(cleanBatch))
                                    {
                                        cmd.CommandText = cleanBatch;
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                               
                                // 3. Commit only if every single batch ran without error
                                trans.Commit();
                                Console.WriteLine("Update completed. Press any key to exit.");

                            }
                            catch (SqlException ex)
                            {
                                Console.WriteLine(ex.Message);

                                // 4. Rollback changes if any batch crashes
                                trans.Rollback();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                trans.Rollback();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            Console.ReadKey();

        }

        private static string ReadContent(string fullPath)
        {
            // 3. Verify the file exists before attempting to read it
            if (!File.Exists(fullPath))
            {

                return string.Empty;
            }

            try
            {
                // 4. Read all text using UTF-8 encoding to preserve Vietnamese accents or special characters
                string fileContent = File.ReadAllText(fullPath, Encoding.UTF8);
                return fileContent;
            }
            catch (IOException ioEx)
            {
               
                return string.Empty;
            }
            catch (Exception ex)
            {

                return string.Empty;
            }
        }
        private static string BuildSqlConnectionString(string server, string database, string user, string password)
        {
            Console.WriteLine($"building database connection string ...");
            // Khởi tạo đối tượng Builder của SqlClient
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            // Gán các thuộc tính tương ứng
            builder.DataSource = server;          // Tên Server hoặc IP (Ví dụ: .\SQLEXPRESS hoặc 192.168.1.1)
            builder.InitialCatalog = database;      // Tên Cơ sở dữ liệu (Database Name)

            // Kiểm tra nếu không nhập User và Pass thì dùng quyền Windows (Windows Authentication)
            if (string.IsNullOrEmpty(user) && string.IsNullOrEmpty(password))
            {
                builder.IntegratedSecurity = true;
            }
            else
            {
                // Sử dụng tài quyền SQL Server (SQL Server Authentication)
                builder.IntegratedSecurity = false;
                builder.UserID = user;
                builder.Password = password;
            }

            // Một số cấu hình tối ưu thêm (Tùy chọn)
            builder.ConnectTimeout = 15;          // Thời gian chờ kết nối tối đa (giây)
            builder.Pooling = true;               // Bật cơ chế tối ưu kết nối Connection Pooling
            builder.MinPoolSize = 0;
            builder.MaxPoolSize = 100;

            //Console.WriteLine($"ConnectionString: {builder.ConnectionString}");
            // Trả về chuỗi ConnectionString hoàn chỉnh dưới dạng String
            return builder.ConnectionString;
        }
        private static string GetAppSettingFromExternalConfig(string configFilePath, string keyName)
        {
            // 1. Kiểm tra file cấu hình có tồn tại không
            if (!File.Exists(configFilePath))
            {
                throw new FileNotFoundException("Không tìm thấy file cấu hình tại: " + configFilePath);
            }

            try
            {
                // 2. Tạo bản đồ ánh xạ trỏ đến file .exe.config đã đổi tên bên ngoài
                ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
                fileMap.ExeConfigFilename = configFilePath;

                // 3. Mở file cấu hình
                Configuration externalConfig = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

                // 4. Truy cập vào phân đoạn <appSettings> và tìm theo Key
                KeyValueConfigurationElement setting = externalConfig.AppSettings.Settings[keyName];

                //Console.WriteLine($"Key: {setting.Key} Value: {setting.Value}");

                if (setting != null)
                {
                    return setting.Value; // Trả về giá trị của Key
                }
                else
                {
                    // Trả về chuỗi rỗng hoặc ném ngoại lệ nếu không tìm thấy cấu hình này
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
    }
}
