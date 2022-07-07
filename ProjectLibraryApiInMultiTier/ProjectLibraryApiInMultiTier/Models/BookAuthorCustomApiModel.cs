namespace ProjectLibraryApiInMultiTier.Models
{
    public class BookAuthorCustomApiModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Resume { get; set; }
        public DateTime PublicationDate { get; set; }
        public int AuthorId { get; set; }

        public string Firstname { get; set; }
        public string AuthorName { get; set; }
        public DateTime Birthdate { get; set; }
        public int GenreId { get; set; }
        public string GenreName { get; set; }

        public string LanguageName { get; set; }
    }
}
