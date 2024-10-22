using System.ComponentModel.DataAnnotations;

namespace Volunteia.Models
{
    public class Person : User
    {
        [Required(ErrorMessage = "Obrigatório inserir uma descrição")]
        [Display(Name = "Descrição do Usuário")]
        [MaxLength(500)]
        public string Bio { get; set; }
        [Required(ErrorMessage = "Obrigatório inserir CPF (apenas números)")]
        [MaxLength(11)]
        public string CPF { get; set; }
    }
}
