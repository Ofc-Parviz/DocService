using System;
using System.Collections.Generic;
using System.Data;

namespace DocService.Data {

    /// <summary>
    /// شی محلی دیتابیس مستندات - برپایه 
    /// اس-کیو-ال لایت - برای استفاده نهایی
    /// </summary>
    public class DocServiceDb {

        #region Injections

        /// <summary>
        /// کلاینت اس-کیو-ال لایت
        /// </summary>
        private readonly SqliteClient _dbClient;
        public DocServiceDb(SqliteClient dbClient)
            => _dbClient = dbClient;
        public DocServiceDb(string connectionKey)
            => _dbClient = new SqliteClient(connectionKey);
        public DocServiceDb(string folderPath, string databaseFilename = Filename)
            => _dbClient = new SqliteClient(folderPath, databaseFilename);

        public const string Filename = "docs.db";

        #endregion

        #region Warm-up

        /// <summary>
        /// راه اندازی اولیه - حداقل یکبار در
        /// طول عمر برنامه باید فراخوانی شود
        /// </summary>
        public void Load() => SqliteDocsDbHelper
            .EnsureDatabase(_dbClient.Confirmed_ConnectionKey);

        #endregion

        #region Get All Docs

        /// <summary>
        /// دریافت اطلاعات همه سند ها
        /// </summary>
        public DataTable GetAllDocs() {

            const string Tsql = @"
                SELECT
                    Id as [شماره],
                    Title as [عنوان],
                    CreatedAtUtc as [تاریخ ایجاد],
                    UpdatedAtUtc as [آخرین ویرایش]
                FROM Documents
                ORDER BY Id DESC;";

            return _dbClient.ExecuteSqliteQuery(Tsql);
        }

        /// <summary>
        /// دریافت اطلاعات همه سند ها
        /// </summary>
        public DocumentModel[] GetAllDocsWithMapping() {

            const string Tsql = @"
                SELECT
                    Id,
                    Title,
                    CreatedAtUtc,
                    UpdatedAtUtc,
                    SectionsJson
                FROM Documents
                ORDER BY Id DESC;";

            var table = _dbClient.ExecuteSqliteQuery(Tsql);

            var result = new List<DocumentModel>();

            if (table != null)
                foreach (DataRow doc in table.Rows)
                    result.Add(doc.MapDocumentModel());

            return result.ToArray();
        }

        #endregion

        #region Get Doc By Id

        /// <summary>
        /// دریافت یک سند بر اساس شناسه عددی
        /// </summary>
        public DocumentModel GetDocById(long id) {

            const string Tsql = @"
                SELECT
                    Id,
                    Title,
                    CreatedAtUtc,
                    UpdatedAtUtc,
                    SectionsJson
                FROM Documents
                WHERE Id = @Id
                LIMIT 1;";

            var table = _dbClient.ExecuteSqliteQuery(Tsql, ("Id", id));

            if (table.Rows.Count == 0) return null;

            return table.Rows[0].MapDocumentModel();
        }

        #endregion

        #region Insert Doc

        /// <summary>
        /// ایجاد سند جدید
        /// </summary>
        public bool InsertDoc(DocumentModel newdoc) {

            if (newdoc == null) return false;

            const string sql = @"
                INSERT INTO Documents
                    (Title, CreatedAtUtc, UpdatedAtUtc, SectionsJson)
                VALUES
                    (@Title, @CreatedAtUtc, @UpdatedAtUtc, @SectionsJson);";

            var createdAt = newdoc.CreatedAtUtc.ToString("O",
                System.Globalization.CultureInfo.InvariantCulture);

            var updatedAt = newdoc.UpdatedAtUtc.ToString("O",
                System.Globalization.CultureInfo.InvariantCulture);

            int affectedRows = _dbClient.ExecuteSqliteCommand
                (sql,
                ("Title", newdoc.Title),
                ("CreatedAtUtc", createdAt),
                ("UpdatedAtUtc", updatedAt),
                ("SectionsJson", newdoc.SectionsJson));

            return affectedRows == 1;
        }

        #endregion

        #region Update Doc

        /// <summary>
        /// ویرایش سند ورودی
        /// </summary>
        public bool UpdateDoc(DocumentModel updateddoc) {

            if (updateddoc == null || updateddoc.Id <= 0) return false;

            const string sql = @"
                UPDATE Documents
                SET
                    Title = @Title,
                    UpdatedAtUtc = @UpdatedAtUtc,
                    SectionsJson = @SectionsJson
                WHERE Id = @Id;";

            string updatedAt = DateTime.UtcNow.ToString("O",
                System.Globalization.CultureInfo.InvariantCulture);

            int affectedRows = _dbClient.ExecuteSqliteCommand
                (sql,
                ("Id", updateddoc.Id),
                ("Title", updateddoc.Title),
                ("UpdatedAtUtc", updatedAt),
                ("SectionsJson", updateddoc.SectionsJson));

            if (affectedRows == 1) {
                updateddoc.UpdatedAtUtc = DateTime.Parse
                    (updatedAt,
                     System.Globalization.CultureInfo.InvariantCulture,
                     System.Globalization.DateTimeStyles.RoundtripKind);
            }

            return affectedRows == 1;
        }

        #endregion

        #region Delete Doc

        /// <summary>
        /// حذف سند بر اساس شناسه
        /// </summary>
        public bool DeleteDoc(long id) {

            if (id <= 0) return false;

            const string sql = @"
                DELETE FROM Documents
                WHERE Id = @Id;";

            int affectedRows = _dbClient
                .ExecuteSqliteCommand(sql, ("Id", id));

            return affectedRows == 1;
        }

        #endregion
    }
}
