
using System.ComponentModel.DataAnnotations;

namespace EsentaSMS.Data.Models
{
    public class RecipientGrp
    {
        public int Id { get; set; }

        [Required]
        public string? GroupName { get; set; }

        public ICollection<Recipient>? Recipients { get; set; }
    }
}
