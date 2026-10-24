using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models;

[Table("Post")]
public class Post
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(160)]
    [Column("Title", TypeName = "NVARCHAR")]
    public string Title { get; set; } = string.Empty;

    [Required]
    [MaxLength(255)]
    [Column("Summary", TypeName = "NVARCHAR")]
    public string Summary { get; set; } = string.Empty;

    [Required]
    [Column("Body", TypeName = "TEXT")]
    public string Body { get; set; } = string.Empty;

    [Required]
    [MaxLength(80)]
    [Column("Slug", TypeName = "VARCHAR")]
    public string Slug { get; set; } = string.Empty;

    [Required]
    [Column("CreateDate", TypeName = "DATETIME")]
    public DateTime CreateDate { get; set; }

    [Required]
    [Column("LastUpdateDate", TypeName = "DATETIME")]
    public DateTime LastUpdateDate { get; set; }

    [Required]
    [ForeignKey(nameof(Category))]
    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    [Required]
    [ForeignKey(nameof(Author))]
    public int AuthorId { get; set; }
    public User? Author { get; set; }
}