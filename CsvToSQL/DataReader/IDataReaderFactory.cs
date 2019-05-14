using System.Data;
using CsvToSQL.DataReader.Configuration;

namespace CsvToSQL.DataReader
{
    public interface IDataReaderFactory
    {
        IDataReader GetCsvDataReader(CsvDataReaderConfiguration configuration);
    }
}
