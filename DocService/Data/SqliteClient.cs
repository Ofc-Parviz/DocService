using System;
using System.IO;
using System.Data;
using System.Data.SQLite;

namespace DocService.Data {

    /// <summary>
    /// کلاینت اس-کیو-ال لایت
    /// </summary>
    public class SqliteClient {

        #region Injections

        /// <summary>
        /// رشته اتصال تایید شده
        /// </summary>
        public string Confirmed_ConnectionKey { get; }

        /// <summary>
        /// کانستراکتور با رشته اتصال مستقیم
        /// </summary>
        public SqliteClient(string ckey) => Confirmed_ConnectionKey = ckey;

        /// <summary>
        /// کانستراکتور با مسیر پوشه و نام فایل دیتابیس
        /// </summary>
        public SqliteClient(string folderPath, string databaseFilename)
            => Confirmed_ConnectionKey = Build_ConnectionString(folderPath, databaseFilename);

        #endregion

        #region Get Sqlite-Connection Instance

        /// <summary>
        /// دریافت شی اتصال به اس-کیو-ال لایت
        /// </summary>
        public SQLiteConnection GetSqliteConnection()
            => new SQLiteConnection(Confirmed_ConnectionKey);

        #endregion

        #region Execute Sqlite Command using T-Sql

        /// <summary>
        /// اجرای کامند روی دیتابیس
        /// </summary>
        public int ExecuteSqliteCommand(string Tsql,
           params (string Key, object Value)[] Parameters) {

            using (var Connection = GetSqliteConnection()) {

                Connection.Open();

                using (var Command = new SQLiteCommand(Tsql, Connection)) {

                    Command.Parameters.Add_With_KeyValue_Collection(Parameters);

                    return Command.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region Execute Sqlite Command using T-Sql with Scalar

        /// <summary>
        /// اجرای کامند روی دیتابیس - بهمراه اولین خروجی
        /// </summary>
        public object ExecuteSqliteScalar(string Tsql,
           params (string Key, object Value)[] Parameters) {

            using (var Connection = GetSqliteConnection()) {

                Connection.Open();

                using (var Command = new SQLiteCommand(Tsql, Connection)) {

                    Command.Parameters.Add_With_KeyValue_Collection(Parameters);

                    return Command.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// اجرای کامند روی دیتابیس - بهمراه اولین خروجی - نوع سفارشی
        /// </summary>
        public T ExecuteSqliteScalar<T>(string Tsql,
           params (string Key, object Value)[] Parameters)
            => (T)ExecuteSqliteScalar(Tsql, Parameters);

        #endregion

        #region Execute Sqlite Query using T-Sql

        /// <summary>
        /// اجرای کوئری روی دیتابیس
        /// </summary>
        public DataTable ExecuteSqliteQuery(string Tsql,
           params (string Key, object Value)[] Parameters) {

            var response = new DataTable();

            using (var Connection = GetSqliteConnection()) {

                Connection.Open();

                using (var Command = new SQLiteCommand(Tsql, Connection)) {

                    Command.Parameters.Add_With_KeyValue_Collection(Parameters);

                    using (var reader = Command.ExecuteReader()) {

                        response.Load(reader);
                    }
                }
            }

            return response;
        }

        #endregion


        // = = = = Common Static Methods

        #region Build Sqlite Connetion-String

        /// <summary>
        /// ایجاد رشته اتصال اس-کیو-ال لایت با
        /// استفاده از مسیر پوشه و نام فایل دیتابیس
        /// </summary>
        public static string Build_ConnectionString
           (string databaseFolder, string databaseName = "demo.db") {

            if (string.IsNullOrWhiteSpace(databaseFolder))
                throw new ArgumentException(nameof(databaseFolder));

            if (string.IsNullOrWhiteSpace(databaseName))
                throw new ArgumentException(nameof(databaseName));

            Directory.CreateDirectory(databaseFolder);

            string dbPath = Path.Combine(databaseFolder, databaseName);

            return $"Data Source={dbPath};Version=3;Pooling=True;";
        }

        #endregion
    }
}
