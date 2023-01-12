namespace Infrastructure.Services;
using Domain.Dtos;
using Npgsql;
using Dapper;
public class Task3Service
{
     private string _connectionString = "Server=127.0.0.1;Port=5432;Database=shop_demo;User Id=postgres;Password=admin;";

        public List<GetTask3> Orders()
        {

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                string sql = "select (o.*),p.productname from orders o join products p ON p.id=o.ProductId GROUP by o.id,p.id HAVING o.price>1000";
                var result = connection.Query<GetTask3>(sql);
                return result.ToList();
            }

        }
}
