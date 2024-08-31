using BenchmarkDotNet.Attributes;
using Bogus;
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

    //public class PhaseBenchMark(IConfiguration configuration)
    //{
    //    private static readonly Faker faker = new();
    //    private readonly string? _connectionString = configuration.GetConnectionString("PayeConnection");

    //    [Params(100)]

    //    public int Size { get; set; }
    //    [Benchmark]

    //    public async Task SqlBulkUpload(List<employee> employees)
    //    {
    //        using var bulk = new SqlBulkCopy(_connectionString);

    //        bulk.DestinationTableName = "dbo.employees";

    //        bulk.ColumnMappings.Add(nameof(employee.first_name), "first_name");
    //        bulk.ColumnMappings.Add(nameof(employee.last_name), "last_name");
    //        bulk.ColumnMappings.Add(nameof(employee.other_name), "other_name");
    //        bulk.ColumnMappings.Add(nameof(employee.designation), "designation");
    //        bulk.ColumnMappings.Add(nameof(employee.title), "title");
    //        bulk.ColumnMappings.Add(nameof(employee.asset_id), "asset_id");
    //        bulk.ColumnMappings.Add(nameof(employee.business_id), "business_id");
    //        bulk.ColumnMappings.Add(nameof(employee.corporate_id), "corporate_id");
    //        bulk.ColumnMappings.Add(nameof(employee.nhis), "nhis");
    //        bulk.ColumnMappings.Add(nameof(employee.gross_income), "gross_income");
    //        bulk.ColumnMappings.Add(nameof(employee.life_assurance), "life_assurance");
    //        bulk.ColumnMappings.Add(nameof(employee.nhf), "nhf");
    //        bulk.ColumnMappings.Add(nameof(employee.nationality), "nationality");
    //        bulk.ColumnMappings.Add(nameof(employee.taxpayer_id), "taxpayer_id");
    //        bulk.ColumnMappings.Add(nameof(employee.email), "email");
    //        bulk.ColumnMappings.Add(nameof(employee.bvn), "bvn");
    //        bulk.ColumnMappings.Add(nameof(employee.basic), "basic");
    //        bulk.ColumnMappings.Add(nameof(employee.tin), "tin");
    //        bulk.ColumnMappings.Add(nameof(employee.rent), "rent");
    //        bulk.ColumnMappings.Add(nameof(employee.other_income), "other_income");
    //        bulk.ColumnMappings.Add(nameof(employee.nationality), "nationality");
    //        bulk.ColumnMappings.Add(nameof(employee.pension), "pension");
    //        bulk.ColumnMappings.Add(nameof(employee.transport), "transport");
    //        bulk.ColumnMappings.Add(nameof(employee.total_income), "total_income");
    //        bulk.ColumnMappings.Add(nameof(employee.zip_code), "zip_code");
    //        bulk.ColumnMappings.Add(nameof(employee.lga_code), "lga_code");
    //        bulk.ColumnMappings.Add(nameof(employee.state_code), "state_code");
    //        bulk.ColumnMappings.Add(nameof(employee.state_tin), "state_tin");
    //        bulk.ColumnMappings.Add(nameof(employee.status), "status");


    //        await bulk.WriteToServerAsync(GetEmployeesDataTable(employees));
    //    }

    //    private DataTable GetEmployeesDataTable(List<employee> employees)
    //    {
    //        var datatable = new DataTable();

    //        datatable.Columns.Add(nameof(employee.first_name), typeof(string));
    //        datatable.Columns.Add(nameof(employee.last_name), typeof(string));
    //        datatable.Columns.Add(nameof(employee.other_name), typeof(string));
    //        datatable.Columns.Add(nameof(employee.designation), typeof(string));
    //        datatable.Columns.Add(nameof(employee.title), typeof(string));
    //        datatable.Columns.Add(nameof(employee.asset_id), typeof(string));
    //        datatable.Columns.Add(nameof(employee.business_id), typeof(int));
    //        datatable.Columns.Add(nameof(employee.corporate_id), typeof(int));
    //        datatable.Columns.Add(nameof(employee.nhis), typeof(string));
    //        datatable.Columns.Add(nameof(employee.gross_income), typeof(string));
    //        datatable.Columns.Add(nameof(employee.life_assurance), typeof(int));
    //        datatable.Columns.Add(nameof(employee.nhf), typeof(string));
    //        datatable.Columns.Add(nameof(employee.nationality), typeof(string));
    //        datatable.Columns.Add(nameof(employee.taxpayer_id), typeof(string));
    //        datatable.Columns.Add(nameof(employee.email), typeof(string));
    //        datatable.Columns.Add(nameof(employee.bvn), typeof(string));
    //        datatable.Columns.Add(nameof(employee.basic), typeof(int));
    //        datatable.Columns.Add(nameof(employee.tin), typeof(string));
    //        datatable.Columns.Add(nameof(employee.rent), typeof(int));
    //        datatable.Columns.Add(nameof(employee.other_income), typeof(string));
    //        datatable.Columns.Add(nameof(employee.pension), typeof(string));
    //        datatable.Columns.Add(nameof(employee.transport), typeof(int));
    //        datatable.Columns.Add(nameof(employee.total_income), typeof(int));
    //        datatable.Columns.Add(nameof(employee.zip_code), typeof(string));
    //        datatable.Columns.Add(nameof(employee.lga_code), typeof(string));
    //        datatable.Columns.Add(nameof(employee.state_code), typeof(string));
    //        datatable.Columns.Add(nameof(employee.state_tin), typeof(string));
    //        datatable.Columns.Add(nameof(employee.status), typeof(int));

    //        foreach (var employee in GetEmployees())
    //        {
    //            datatable.Rows.Add(
    //                                employee.first_name,
    //                                employee.last_name,
    //                                employee.other_name,
    //                                employee.designation,
    //                                employee.title,
    //                                employee.asset_id,
    //                                employee.business_id,
    //                                employee.corporate_id,
    //                                employee.nhis,
    //                                employee.gross_income,
    //                                employee.life_assurance,
    //                                employee.nhf,
    //                                employee.nationality,
    //                                employee.taxpayer_id,
    //                                employee.email,
    //                                employee.bvn,
    //                                employee.basic,
    //                                employee.tin,
    //                                employee.rent,
    //                                employee.other_income,
    //                                employee.pension,
    //                                employee.transport,
    //                                employee.total_income,
    //                                employee.zip_code,
    //                                employee.lga_code,
    //                                employee.state_code,
    //                                employee.state_tin,
    //                                employee.status
    //                                );
    //        }

    //        return datatable;
    //    }
    //    private employee[] GetEmployees()
    //    {
    //        return Enumerable
    //             .Range(1, Size)
    //             .Select(_ => new employee
    //             {
    //                 first_name = faker.Name.FirstName(),
    //                 last_name = faker.Name.LastName(),
    //                 other_name = faker.Name.FullName(),
    //                 designation = faker.Company.CompanyName(),
    //                 title = faker.Name.Prefix(),
    //                 asset_id = faker.Random.Guid().ToString(),
    //                 business_id = faker.Random.Int(1, 1000),
    //                 corporate_id = faker.Random.Int(1, 1000),
    //                 nhis = faker.Random.String(10),
    //                 gross_income = faker.Finance.Amount().ToString(), 
    //                 life_assurance = (int)faker.Finance.Amount(), 
    //                 nhf = faker.Finance.Amount().ToString(), 
    //                 nationality = faker.Address.Country(),
    //                 taxpayer_id = faker.Random.String(10),
    //                 email = faker.Internet.Email(),
    //                 bvn = faker.Random.String(10),
    //                 basic = (int)faker.Finance.Amount(), 
    //                 tin = faker.Random.String(10),
    //                 rent = (int)faker.Finance.Amount(), 
    //                 other_income = faker.Finance.Amount().ToString(),
    //                 pension = faker.Finance.Amount().ToString(), 
    //                 transport = (int)faker.Finance.Amount(),
    //                 total_income = (int)faker.Finance.Amount(), 
    //                 zip_code = faker.Address.ZipCode(),
    //                 lga_code = faker.Random.Int(10000, 99999).ToString(), 
    //                 state_code = faker.Random.Int(10000, 99999).ToString(), 
    //                 state_tin = faker.Random.Int(10000, 99999).ToString(), 
    //                 status = faker.Random.Int(0, 1)

    //             })
    //             .ToArray();
    //    }
    //}
}
