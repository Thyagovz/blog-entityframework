namespace Blog.Models;

// [Id].INT.NOT.NULL .IDENTITY(1,1),
// [CategoryId] .INT .NOT . NULL,
// [Author Id] .INT .NOT .NULL,
// [Title] . VARCHAR(160) .NOT .NULL,
// [Summary ] . VARCHAR (255) .NOT . NULL,
// [Body] . TEXT . NOT . NULL,
// [Slug] . VARCHAR(80) .NOT .NULL,
// [CreateDate] .DATETIME . NOT . NULL . DEFAULT(GETDATE()),
// [LastUpdateDate] .DATETIME . NOT . NULL . DEFAULT(GETDATE()),


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