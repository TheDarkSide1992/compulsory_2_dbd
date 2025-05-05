namespace ECommerce.Infrastructure.Models;

public class UserDbModel
{
    Guid UserId { get; set; }
    string Email { get; set; }
    string Name { get; set; }
    AddressDbModel AddressDb { get; set; }
    PasswordDbModel PasswordDb { get; set; }
}