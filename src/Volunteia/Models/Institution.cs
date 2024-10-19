using System.ComponentModel.DataAnnotations;

namespace Volunteia.Models
{
    public class Institution : User
    {
        [Required(ErrorMessage = "Obrigatório informar endereço.")]
        [MaxLength(150)]
        [Display(Name = "Endereço")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Obrigatório informar CNPJ.")]
        [MaxLength(18)]
        public string CNPJ { get; set; }
        [Required(ErrorMessage = "Informe uma descrição sobre a empresa.")]
        [MaxLength(500)]
        [Display(Name = "Descrição da Empresa")]
        public string ShortBio { get; set; }
    }
}
