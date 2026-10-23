namespace Blog.Models;

// Representa uma publicação do blog. Os comentários abaixo registram
// o formato esperado na tabela correspondente do banco de dados.
// Id e as chaves estrangeiras são inteiros; as datas devem ter valor padrão
// definido pelo banco (GETDATE) quando o registro for criado ou atualizado.
public class Post
{
   public int Id { get; set; }
   public int CategoryId { get; set; }
   public int AuthorId { get; set; }
   public string Title { get; set; } = string.Empty;
   public string Summary { get; set; } = string.Empty;
   public string Body { get; set; } = string.Empty;
   public string Slug { get; set; } = string.Empty;
   public DateTime CreateDate { get; set; }
   public DateTime LastUpdateDate { get; set; }
}