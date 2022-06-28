namespace ProjectLibraryApiInMultiTier.Models
{
    public class BookApiModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Resume { get; set; }
        public DateTime PublicationDate { get; set; }
        public int LanguageId { get; set; }
    }
}
