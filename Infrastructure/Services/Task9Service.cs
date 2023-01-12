namespace Infrastructure.Services;
using Domain.Dtos;
using Npgsql;
using Dapper;
public class Task9Service
{
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=shop_demo;User Id=postgres;Password=admin;";

        public List<GetTask9> Orders()
        {

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                string sql = " select (p.*) from products p where p.company='Samsung' or p.company='Xiaomi' or p.company='Apple'";
                var result = connection.Query<GetTask9>(sql);
                return result.ToList();
            }

        }
}