using System;

namespace BigdanLab2
{
    class Paper
    {
        public string title { get; set; }
        public Person author { get; set; }
        public DateTime publicationDate { get; set; }

        public Paper()
        {
            title = "Title";
            author = new Person();
            publicationDate = new DateTime(2015, 12, 25);
        }

        public Paper(string pTitle, Person pAuthor, DateTime pPublicationDate)
        {
            title = pTitle;
            author = pAuthor;
            publicationDate = pPublicationDate;
        }

        public override string ToString()
        {

            return title + " " + author + " " + publicationDate;
        }
    }
}
