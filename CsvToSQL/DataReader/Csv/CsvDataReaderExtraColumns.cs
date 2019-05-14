using System;
using System.Collections.Generic;
using CsvToSQL.DataReader.Decorators;

namespace CsvToSQL.DataReader.Csv
{
    /// <summary>
    /// Convenience class utilising CsvDataReader and adding extra columns functionality to it.
    /// </summary>
    public class CsvDataReaderExtraColumns : DataReaderExtraColumns
    {
        public CsvDataReaderExtraColumns(string csvFilePath, List<TypeCode> typeMappings) : base(new CsvDataReader(csvFilePath, typeMappings))
        {
        }
    }
}
