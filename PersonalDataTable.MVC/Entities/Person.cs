using System.ComponentModel.DataAnnotations;

namespace PersonalDataTable.MVC.Entities
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Imię")]
        public required string Name { get; set; }
        
        [Required]
        [Display(Name = "Nazwisko")]
        public required  string Surname { get; set; }

        [Display(Name = "Pierwszy adres email")]
        public required List<Email> Emails { get; set; }
        
        [Display(Name = "Opis")]
        public string? Description { get; set;} 
    }
}
