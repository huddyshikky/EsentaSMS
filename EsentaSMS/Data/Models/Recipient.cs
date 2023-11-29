namespace EsentaSMS.Data.Models
{
    public class Recipient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public int RecipientGrpId { get; set; }
        public required RecipientGrp RecipientGrp { get; set; }
    }
}
