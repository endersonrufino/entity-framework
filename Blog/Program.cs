using blog.Data;
using blog.Models;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new DataContext();

            // context.Users.Add(new User
            // {
            //     Bio = "teste entity azul",
            //     Email = "manoel.gomes@gmail.com",
            //     Image = "mgazul.png",
            //     Name = "Manoel Gomes",
            //     PasswordHash = "123456",
            //     Slug = "manoel-gomes"
            // });
            var user = context.Users.FirstOrDefault(x => x.Id == 3);
            var post = new Post
            {
                Author = user,
                Body = "minha caneta e azul",
                Category = new Category{
                    Name = "Caneta",
                    Slug = "Canet-azul"
                },
                CreateDate = DateTime.Now,
                Slug = "caneta-azul",
                Summary = "caneta azul, azul caneta",
                Title = "Minha caneta"

            };

            context.Posts.Add(post);

            context.SaveChanges();
        }
    }
}