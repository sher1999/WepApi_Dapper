namespace Infrastructure.Services;
using Domain.Dtos;
using Npgsql;
using Dapper;
public class Task6Service
{
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=shop_demo;User Id=postgres;Password=admin;";

        public List<GetTask6> Orders()
        {

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                string sql = "  select (c.*) from customers c right join products p ON p.id=c.id right join orders o on o.CustomerId =c.id";
                var result = connection.Query<GetTask6>(sql);
                return result.ToList();
            }

        }
}