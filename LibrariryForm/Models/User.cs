using Microsoft.Build.Framework;

namespace LibrariryForm.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string PrivateInfo { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string BookInfo { get; set; }
        [Required]
        public string WorkInfo { get; set; }
        [Required]
        public string Fin { get; set; }
        [Required]
        public string SeriyaNumber { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public bool IsDeactive { get; set; }
    }
}
