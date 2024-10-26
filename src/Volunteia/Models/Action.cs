
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;


namespace Volunteia.Models;

[Table("Actions")]

public class Action

{
    [Key]
    public int ActionId { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    [Required(ErrorMessage = "Selecione uma foto para a ação")]
    [Display(Name = "Foto")]
    public byte[] Foto { get; set; }

    [Required(ErrorMessage = "Informe o nome")]
    [Display(Name = "Nome")]
    public string Name { get; set; }

    public bool Patrocinador { get; set; }

    [Required(ErrorMessage = "Informe a data")]
    public DateTime ActionDate { get; set; }

    [Required(ErrorMessage = "Informe a descrição")]
    [Display(Name = "Descrição")]
    public string ActionBio { get; set; }

    [Required(ErrorMessage = "Informe a ODS")]
    [Display(Name = "ODS")]
    public TipoODS ODS { get; set; }

    public List<User> ActionAdmin  { get; set; } = new List<User>();
   

    public List<User> VonluteersList { get; set; } = new List<User>();

    [Required(ErrorMessage = "Informe o número aproximado de voluntários")]
    [Display(Name = "Número de voluntários esperado")]
    public int VonlunteersTotal { get; set; }

    [Required(ErrorMessage = "Informe o número de estimativa de pessoas alcançadas")]
    [Display(Name = "Estimativa de pessoas alcançadas ")]
    public int NumberOfPeopleHelped { get; set; }
    public List<User> Sponsor { get; set; } = new List<User>();

    public int Rate { get; set; }
}

public enum TipoODS
{
    [Display(Name = "Erradicação da Pobreza")]
    ErradicacaoDaPobreza,
    [Display(Name = "Fome Zero e Agricultura Sustentável")]
    FomeZeroEAgricultura,
    [Display(Name = "Saúde e Bem-Estar")]
    SaudeEBemEstar,
    [Display(Name = "Educação de Qualidade")]
    EducacaoDeQualidade,
    [Display(Name = "Igualdade de Gênero")]
    IgualdadeDeGenero,
    [Display(Name = "Água Potável e Saneamento")]
    AguaPotavelESaneamento,
    [Display(Name = "Energia Acessível e Limpa")]
    EnergiaAcessivelELimpa,
    [Display(Name = "Trabalho Decente e Crescimento Econômico")]
    TrabalhoDecenteECrescimentoEconomico,
    [Display(Name = "Indústria, Inovação e Infraestrutura")]
    IndustriaInovacaoEInfraestrutura,
    [Display(Name = "Redução das Desigualdades")]
    ReducaoDasDesigualdades,
    [Display(Name = "Cidades e Comunidades Sustentáveis")]
    CidadesEComunidadesSustentaveis,
    [Display(Name = "Consumo e Produção Responsáveis")]
    ConsumoEProducaoResponsaveis,
    [Display(Name = "Ação contra a Mudança Global do Clima")]
    AcaoContraAMudancaGlobalDoClima,
    [Display(Name = "Vida na Água")]
    VidaNaAgua,
    [Display(Name = "Vida Terrestre")]
    VidaTerrestre,
    [Display(Name = "Paz, Justiça e Instituições Eficazes")]
    PazJusticaEInstituicoesEficazes,
    [Display(Name = "Parcerias e Meios de Implementação")]
    ParceriasEMeiosDeImplementacao
}



