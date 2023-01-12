namespace Infrastructure.Services;
using Domain.Dtos;
using Npgsql;
using Dapper;
public class Task8Service
{
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=shop_demo;User Id=postgres;Password=admin;";

        public List<GetTask8> Orders()
        {

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                string sql = "  select (p.*),o.price as PriceAll from products p join orders o on o.ProductId =p.id group by p.id,o.id";
                var result = connection.Query<GetTask8>(sql);
                return result.ToList();
            }

        }
}