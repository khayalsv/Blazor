using BlazorDapper.Data;
using BlazorDapper.Pages;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace BlazorDapper.Service
{
    public class EmployeeServiceDapper
    {
        private string connectionString = "";

        public EmployeeServiceDapper()
        {
            connectionString = @"Server=SALIMOV\SQLEXPRESS;Database=DapperEmp; Trusted_Connection=True; MultipleActiveResultSets=true";
        }

        public IDbConnection Connection { get { return new SqlConnection(connectionString); } }

        public void Create(Employee employee)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"Insert into Employees (Name,Department) values (@Name,@Department)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, employee);
            }
        }


        public async Task<IEnumerable<Employee>> GetAll()
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    return await dbConnection.QueryAsync<Employee>("Select * from Employees");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Employee GetById(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"Select * from Employees where Id=@Id";
                dbConnection.Open();
                return dbConnection.Query<Employee>(sQuery, new { Id = id }).FirstOrDefault();
            }
        }

        public void Update(Employee employee)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"Update Employees set Name=@Name ,Department=@Department where Id=@Id";
                dbConnection.Open();
                dbConnection.Query<Employee>(sQuery, employee);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"Delete from Employees where Id=@Id";
                dbConnection.Open();
                dbConnection.Query<Employee>(sQuery, new {Id=id});
            }
        }
    }
}
