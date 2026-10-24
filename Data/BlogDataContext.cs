using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Blog.Data;

public class BlogDataContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
    // Habilite quando o relacionamento entre posts e tags estiver configurado.
    // public DbSet<PostTag> PostTags { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<User> Users { get; set; }
    // Habilite quando o relacionamento entre usuários e funções estiver configurado.
    // public DbSet<UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Lê a configuração a partir da pasta de saída da aplicação.
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        // Recupera a conexão nomeada usada pelo provedor do SQL Server.
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            // Falha explicitamente para evitar iniciar o contexto sem conexão válida.
            throw new InvalidOperationException(
                "A connection string 'DefaultConnection' não foi configurada em appsettings.json.");
        }

        // Configura o Entity Framework Core para trabalhar com SQL Server.
        options.UseSqlServer(connectionString);

        options.LogTo(Console.WriteLine);
    }
}
