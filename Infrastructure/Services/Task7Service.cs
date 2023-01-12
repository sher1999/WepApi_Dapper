namespace Infrastructure.Services;
using Domain.Dtos;
using Npgsql;
using Dapper;
public class Task7Service
{
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=shop_demo;User Id=postgres;Password=admin;";

        public List<GetTask7> Orders()
        {

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                string sql = " select (c.*), o.Productcount from customers c join orders o on o.CustomerId=c.id GROUP by o.id,c.id";
                var result = connection.Query<GetTask7>(sql);
                return result.ToList();
            }

        }
}