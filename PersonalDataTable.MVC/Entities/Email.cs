using System.ComponentModel.DataAnnotations;

namespace PersonalDataTable.MVC.Entities
{
    public class Email
    {
        public int Id { get; set; }

        [Required]
        public int PersonId { get; set; }
        
        [EmailAddress(ErrorMessage = "Niepoprawny adres email")]
        public required string EmailAddress { get; set; }
    }
}
