using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DocService.Data {
    public static class SqliteExtensionMethods {

        public static void Add_With_KeyValue_Collection
            (this SQLiteParameterCollection collection,
             params (string Key, object Value)[] Parameters) {

            foreach (var Param in Parameters)
                collection.AddWithValue("@" + Param.Key, Param.Value ?? DBNull.Value);
        }
    }
}
