using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteia.Models
{
    [Table("User")]
    public abstract class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informar seu nome.")]
        [MaxLength(100)]
        [Display(Name ="Nome")]
        public string Name { get; set; }
        public int NumberOfActions { get; set; }
        public ICollection<Action> ActionLog { get; set; }
        [Required(ErrorMessage = "Obrigatório informar seu email.")]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Obrigatório informar seu telefone.")]
        [MaxLength(50)]
        [Display(Name = "Telefone")]
        public string Phone { get; set; }
        public bool IsRestricted { get; set; }
        public bool IsBenefactor { get; set; }
        public bool IsPrivate { get; set; }
        public UserStatus UserStatus { get; set; }

        public ICollection<Action> Action;
    }

    public enum UserStatus
    {
        Admin,
        User
    }
}
