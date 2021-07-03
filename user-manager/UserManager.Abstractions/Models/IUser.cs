namespace UserManager.Abstractions.Models
{
    public interface IUser : IIdentifiable
    {
        string EmailAddress { get; set; }
        
        string Name { get; set; }
        
        string Password { get; set; }
    }
}