namespace Infrastructure.Services;
using Domain.Dtos;
using Npgsql;
using Dapper;
public class Task1Service
{
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=shop_demo;User Id=postgres;Password=admin;";

        public List<GetTask1> Orders()
        {

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                string sql = "select (o.*),(p.*),(c.*)from orders o join products p ON p.id=o.ProductId join  customers c on c.id=o.CustomerId ";
                var result = connection.Query<GetTask1>(sql);
                return result.ToList();
            }

        }
}
