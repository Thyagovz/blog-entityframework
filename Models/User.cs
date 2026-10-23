namespace Blog.Models;

// [Id] INT NOT NULL IDENTITY(1, 1),
// [Name] NVARCHAR(80) NOT NULL,
// [Email] VARCHAR(200) NOT NULL,
// [PasswordHash] VARCHAR(255) NOT NULL,
// [Bio] TEXT NOT NULL,
// [Image] VARCHAR(2000) NOT NULL,
// [Slug] VARCHAR(80) NOT NULL,
public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
}