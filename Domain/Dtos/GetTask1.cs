namespace Domain.Dtos;

public class GetTask1
{
    public int Id { get; set; }
            public int ProductId { get; set; }
            public int CustomerId { get; set; }
            public DateTime CreatedAt  { get; set; }
            public int ProductCount { get; set; }
            public decimal Price { get; set; }
            public string ProductName { get; set; }
            public string FirstName { get; set; }

            public GetTask1()
            {
            }
}
