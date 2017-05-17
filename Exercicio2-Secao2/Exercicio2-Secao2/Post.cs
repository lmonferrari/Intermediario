using System;

namespace Exercicio2_Secao2
{
    class Post {

        public int UpVotes { get; private set; }
        public int DownVotes { get; private set; }
        public DateTime DateCreation { get; private set; }
        public string Description { get;  set; }
        public string Title { get;  set; }


        public Post(string title, string description)
        {
            DateCreation = DateTime.Now;
            if (string.IsNullOrWhiteSpace(title))
                title = "Lamme! You forget the title!";

            if (string.IsNullOrWhiteSpace(description))
                description = "Oh Gosh! You forget the description!";

            this.Description = description;
            this.Title = title;
        }

        public void UpVote()
        {
            UpVotes++;
        }

        public void DownVote()
        {
            DownVotes++;
        }
    }
}
