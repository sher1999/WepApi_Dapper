namespace Infrastructure.Services;
using Domain.Dtos;
using Npgsql;
using Dapper;
public class Task5Service
{
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=shop_demo;User Id=postgres;Password=admin;";

        public List<GetTask5> Orders()
        {

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                string sql = "  select (c.*) from customers c FULL join products p ON p.id=c.id FULL join orders o on o.CustomerId =c.id";
                var result = connection.Query<GetTask5>(sql);
                return result.ToList();
            }

        }
}