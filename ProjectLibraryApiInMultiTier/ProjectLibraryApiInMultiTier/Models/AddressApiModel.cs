namespace ProjectLibraryApiInMultiTier.Models
{
    public class AddressApiModel
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string? Box { get; set; }
    }
}
