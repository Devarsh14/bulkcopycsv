using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CsvToSQL
{
    public interface IBulkCopyUtility
    {
        void BulkCopy(string tableName, IDataReader dataReader);

        void BulkCopy(string tableName, IDataReader dataReader, Action<SqlBulkCopy> configureSqlBulkCopy);
    }
}