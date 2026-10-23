using Blog.Data;
using Blog.Models;

namespace Blog;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new BlogDataContext())
        {
            // Exemplo de inclusão: cria uma tag e persiste o registro no banco.
            // var tag = new Tag { Name = "JAVASCRIPT", Slug = "javascript" };
            // context.Tags.Add(tag);
            // context.SaveChanges();

            // Exemplo de consulta e atualização: localiza a tag pelo Id
            // e altera seus dados somente quando o registro existe.
            // var tag = context.Tags.FirstOrDefault(x => x.Id == 5);
            // if (tag is not null)
            // {
            //     tag.Name = ".NET";
            //     tag.Slug = "dotnet";
            //     context.Update(tag);
            //     context.SaveChanges();
            // }

            // Exemplo de exclusão: localiza a tag e a remove do banco
            // somente quando a consulta retorna um registro.
            // var tag = context.Tags.FirstOrDefault(x => x.Id == 5);
            // if (tag is not null)
            // {
            //     context.Remove(tag);
            //     context.SaveChanges();
            // }

            var tags = context.Tags;

            foreach (var tag in tags)
            {
                Console.WriteLine(tag.Name);
            }
        }
    }
}