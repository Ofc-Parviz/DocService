
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace DocService.Data {
    /// <summary>
    /// کلاس کمکی برای دیتابیس مستندات بر پایه اس-کیو-ال لایت
    /// </summary>
    public static class SqliteDocsDbHelper {

        /// <summary>
        /// اظمینان حاصل کردن از وجود دیتابیس
        /// </summary>
        public static void EnsureDatabase(string connectionString) {

            using (var connection = new SQLiteConnection(connectionString)) {

                connection.Open();

                // ایجاد جدول در صورت عدم وجود
                const string createTableSql = @"
                    CREATE TABLE IF NOT EXISTS Documents
                    (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Title TEXT NOT NULL,
                        CreatedAtUtc TEXT NOT NULL,
                        UpdatedAtUtc TEXT NOT NULL,
                        SectionsJson TEXT NOT NULL
                    );";

                using (var command = new SQLiteCommand(createTableSql, connection)) {
                    command.ExecuteNonQuery();
                }

                // بررسی ستون های مورد نیاز
                var existingColumns = new HashSet<string>(
                    StringComparer.OrdinalIgnoreCase);

                using (var command = new SQLiteCommand
                    ("PRAGMA table_info(Documents);", connection))
                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        existingColumns.Add(
                            reader["name"].ToString());
                    }
                }

                EnsureColumn(
                    connection,
                    existingColumns,
                    "Title",
                    "TEXT NOT NULL DEFAULT ''");

                EnsureColumn(
                    connection,
                    existingColumns,
                    "CreatedAtUtc",
                    "TEXT NOT NULL DEFAULT ''");

                EnsureColumn(
                    connection,
                    existingColumns,
                    "UpdatedAtUtc",
                    "TEXT NOT NULL DEFAULT ''");

                EnsureColumn(
                    connection,
                    existingColumns,
                    "SectionsJson",
                    "TEXT NOT NULL DEFAULT ''");
            }
        }

        /// <summary>
        /// اطمینان حاصل کردن از وجود ستون جدول دیتابیس
        /// </summary>
        private static void EnsureColumn(
            SQLiteConnection connection,
            HashSet<string> existingColumns,
            string columnName,
            string columnDefinition) {
            if (existingColumns.Contains(columnName))
                return;

            string sql =
                $"ALTER TABLE Documents ADD COLUMN {columnName} {columnDefinition};";

            using (var command = new SQLiteCommand(sql, connection)) {
                command.ExecuteNonQuery();
            }
        }


        public static DocumentModel MapDocumentModel(this DataRow row) => new DocumentModel {

            Id = Convert.ToInt64(row["Id"]),

            Title = Convert.ToString(row["Title"]),

            CreatedAtUtc = DateTime.Parse(
                    Convert.ToString(row["CreatedAtUtc"]),
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.RoundtripKind),

            UpdatedAtUtc = DateTime.Parse(
                    Convert.ToString(row["UpdatedAtUtc"]),
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.RoundtripKind),

            SectionsJson = Convert.ToString(row["SectionsJson"])
        };
    }
}
