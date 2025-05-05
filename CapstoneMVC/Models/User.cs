using System.ComponentModel.DataAnnotations;

namespace CapstoneMVC.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "UserType is Required")]
        public int UserType { get; set; }
        [Required(ErrorMessage = "IsConfidential is Required")]
        public bool IsConfidential { get; set; }
    }
}
