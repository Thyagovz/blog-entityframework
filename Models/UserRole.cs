using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Blog.Models;

[Table("UserRole")]
[PrimaryKey(nameof(UserId), nameof(RoleId))]
public class UserRole
{
    [Required]
    public int UserId { get; set; }

    [Required]
    public int RoleId { get; set; }

    [ForeignKey(nameof(UserId))]
    public User? User { get; set; }

    [ForeignKey(nameof(RoleId))]
    public Role? Role { get; set; }
}