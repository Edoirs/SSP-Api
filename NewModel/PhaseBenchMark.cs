//using BenchmarkDotNet.Attributes;
//using Bogus;
using Microsoft.Data.SqlClient;
using System.Data;

namespace SelfPortalAPi.NewModel
{
    public class PhaseBenchMark
    {
        private readonly string? _connectionString;

        public PhaseBenchMark(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("SelfServiceConnect");
        }

        public async Task SqlBulkUpload<T>(List<T> data, string tableName)
        {
            using var bulkCopy = new SqlBulkCopy(_connectionString);
            bulkCopy.DestinationTableName = tableName;

            var dataTable = ConvertToDataTable(data);
            await bulkCopy.WriteToServerAsync(dataTable);
        }

        private DataTable ConvertToDataTable<T>(List<T> data)
        {
            var dataTable = new DataTable();
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                dataTable.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
            }

            foreach (var item in data)
            {
                var values = new object[properties.Length];
                for (var i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(item) ?? DBNull.Value;
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }
}
