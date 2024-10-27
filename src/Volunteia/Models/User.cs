using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteia.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Obrigatório informar seu nome.")]
        [MaxLength(200)]
        [Display(Name ="Nome")]
        public string Name { get; set; }
        public int NumberOfActions { get; set; }
        public ICollection<UserAction> ActionLog { get; set; }
        [Required(ErrorMessage = "Obrigatório informar seu email.")]
        [MaxLength(200)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Obrigatório informar seu telefone.")]
        [MaxLength(200)]
        [Display(Name = "Telefone")]
        public string Phone { get; set; }
        public bool IsRestricted { get; set; }
        public bool IsBenefactor { get; set; }
        public bool IsPrivate { get; set; }
        public UserStatus UserStatus { get; set; }

        public ICollection<UserAction> Action;
    }

    public enum UserStatus
    {
        Admin,
        User
    }
}
