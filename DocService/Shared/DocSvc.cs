using Sm.Ui.Core;
using DocService.Data;

namespace DocService {
    /// <summary>
    /// کلاس مشترک عمومی
    /// </summary>
    public static class DocSvc {

        private static DocServiceDb _database = null;

        /// <summary>
        /// شی مرکزی دیتابیس سرتاسر برنامه
        /// </summary>
        public static DocServiceDb Database {

            get {

                if (_database == null)
                    _database = new DocServiceDb(folderPath: GuiCore
                        .Current_Config.Di_Handler.DataBaseFilesFolder);

                return _database;
            }
        }
    }
}
