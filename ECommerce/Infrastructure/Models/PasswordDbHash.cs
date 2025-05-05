namespace ECommerce.Infrastructure.Models;

public class PasswordDbHash
{
    public int UserId { get; set; }
    public required string Hash { get; set; }
    public required string Salt { get; set; }
    public required string Algorithm { get; set; }
}