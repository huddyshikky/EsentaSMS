namespace EsentaSMS.Data.Models
{
    public class SmsApi
    {
        public int Id { get; set; }
        public required string SenderId { get; set; }
     
        public required string UserName { get; set; }

        public required string ApiKey { get; set; }
        public required string AccountName { get; set; }

        public int OrganisationId { get; set; }
        public required Organisation Organisation { get; set; }

        public ICollection<Sms> Sms { get; set; }

    }
}
