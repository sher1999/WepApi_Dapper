namespace Infrastructure.Services;
using Domain.Dtos;
using Npgsql;
using Dapper;
public class Task10Service
{
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=shop_demo;User Id=postgres;Password=admin;";

        public List<GetTask10> Orders()
        {

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                string sql = " select (p.*) from products p where p.company!='Samsung' and p.company!='Xiaomi' and p.company!='Apple'";
                var result = connection.Query<GetTask10>(sql);
                return result.ToList();
            }

        }
}