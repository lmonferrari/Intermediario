using System;

namespace Exercicio2_Secao2
{
    class Post
    {
        private int _upVotes;
        private int _downVotes;
        private DateTime _creationDate;
        private string _description;
        private string _title;

        public Post(string title, string description)
        {
            if (string.IsNullOrWhiteSpace(title))
                title = "Lamme! You forget the title!";

            if (string.IsNullOrWhiteSpace(description))
                description = "Oh Gosh! You forget the description!";

            _creationDate = DateTime.Now;
            _description = description;
            _title = title;
            _upVotes = 0;
            _downVotes = 0;
        }

        public void UpVote()
        {
            _upVotes++;
        }

        public void DownVote()
        {
            _downVotes++;
        }

        public override string ToString()
        {
            return "\nTitle: " + _title +
                   "\nDescription :" + _description +
                   "\nCreation date: " + _creationDate +
                   "\nUp Votes: " + _upVotes +
                   " - Down Votes: " + _downVotes;
        }
    }
}
