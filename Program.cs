using Blog.Data;
using Blog.Models;

namespace Blog;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new BlogDataContext())
        {
            // var tag = new Tag {Name="JAVASCRIPT", Slug = "javascript"};
            // context.Tags.Add(tag);
            // context.SaveChanges();

            var tag = context.Tags.FirstOrDefault(x => x.Id == 5);
            if (tag is not null)
            {
                tag.Name = ".NET";
                tag.Slug = "dotnet";

                context.Update(tag);
                context.SaveChanges();
            }
        }
    }
}