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
                Console.WriteLine("\nPost title: {0}\nPost description: {1}", post.Title, post.Description);
                Console.WriteLine("Creation Date: {0}", post.DateCreation);
                Console.WriteLine("Up votes: {0}, Down votes: {1} \n", post.UpVotes, post.DownVotes);

                Console.WriteLine("Type 'up' for Up-Vote or 'down' to Down-Vote");
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
