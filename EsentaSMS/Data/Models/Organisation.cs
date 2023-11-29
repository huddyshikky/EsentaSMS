namespace EsentaSMS.Data.Models
{
    public class Organisation
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; } 
        public string? Email { get; set; }
        public string? City { get; set; }
        public string? County { get; set; }
        public string? Logo { get; set; }

        public ICollection<SmsApi>? SmsApi { get; set; }
    }
}
