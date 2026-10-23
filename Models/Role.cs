namespace Blog.Models;

// Representa uma função/permissão atribuída a usuários.
// O Slug deve ser único para identificar a função de forma estável.
public class Role
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
}