using System.ComponentModel.DataAnnotations;

namespace EsentaSMS.Data.Models
{
    public class Sms
    {
        public int Id { get; set; }
        public DateTime DraftDate { get; set; }
        public DateTime SendDate { get; set; }
        [MaxLength(800)]
        public string Message { get; set; }
        public int SmsLength { get;set; }

        [DataType(DataType.Currency)]
        public decimal Cost { get; set; }
        public SmsCategoryEnum SmsCategory { get; set; }
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        public int? RecipientId { get; set; }
        public Recipient? Recipient { get; set; }

        public int SmsApiId { get; set; }
        public SmsApi? SmsApi { get; set; }

    }
}
