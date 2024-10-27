using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteia.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informar seu nome.")]
        [MaxLength(100)]
        [Display(Name ="Nome")]
        public string Name { get; set; }
        [Display(Name = "Número de ações")]
        public int NumberOfActions { get; set; }
        public ICollection<Action> ActionLog { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o email.")]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o telefone.")]
        [MaxLength(50)]
        [Display(Name = "Telefone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Obrigatório informar endereço. O endereço é privado para usuários tipo pessoas")]
        [MaxLength(150)]
        [Display(Name = "Endereço")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o documento.")]
        [MaxLength(18)]
        [Display(Name = "CPF ou CNPJ (apenas números)")]
        public string CPForCNPJ { get; set; }
        [Required(ErrorMessage = "Informe uma bio sobre o usuário.")]
        [MaxLength(500)]
        [Display(Name = "Bio")]
        public string ShortBio { get; set; }
        [Display(Name = "Restrito")]
        public bool IsRestricted { get; set; }
        [Display(Name = "Benfeitor")]
        public bool IsBenefactor { get; set; }
        [Display(Name = "Modo Privado")]
        [Required(ErrorMessage = "Informe se o usuário estará no modo privado.")]
        public bool IsPrivate { get; set; }
        [Display(Name = "Tipo de usuário")]
        public UserStatus UserStatus { get; set; }

        public ICollection<Action> Action;
    }

    public enum UserStatus
    {
        Admin,
        Instituição,
        Pessoa
    }
}
