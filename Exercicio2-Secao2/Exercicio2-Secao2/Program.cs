using System;

namespace Exercicio2_Secao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Title to your post: ");
            var title = Console.ReadLine();

            Console.WriteLine("Description of your post: ");
            var description = Console.ReadLine();

            var post = new Post(title, description);

            while (true)
            {
                Console.WriteLine(post.ToString());

                Console.WriteLine("\nType 'up' for Up-Vote or 'down' to Down-Vote");
                var input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "up": post.UpVote(); break;
                    case "down": post.DownVote(); break;
                    default: Console.WriteLine("Choose up or down!"); break;
                }
            }
        }
    }
}
