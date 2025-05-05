namespace ECommerce.Domain.Entities;

public class UserModel
{
    Guid UserId { get; set; }
    string Email { get; set; }
    string Name { get; set; }
    AddressModel Address { get; set; }
    PasswordModel Password { get; set; }
}