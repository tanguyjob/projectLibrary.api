namespace ProjectLibraryApiInMultiTier.Models
{
    public class BorrowingBookCustomModel
    {
        public int BorrowingId { get; set; }
        public DateTime DateBack { get; set; }
        public DateTime DateBegin { get; set; }
        public bool Additional { get; set; }
        public int CopyId { get; set; }
        public string Title { get; set; }
        public string Resume { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
