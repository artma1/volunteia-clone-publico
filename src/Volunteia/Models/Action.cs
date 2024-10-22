
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Volunteia.Models;

    
     [Table("Action")]

public class Action

{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Selecione uma foto para a ação")]
    [Display(Name = "Foto")]
    public byte[] Foto { get; set; }

    [Required(ErrorMessage = "Informe o nome")]
    [Display(Name = "Nome")]
    public string Nome { get; set; }

    public Patrocinio Patrocinador { get; set; }

    [Required(ErrorMessage = "Informe a data")]
    public DateTime Data { get; set; }

    [Required(ErrorMessage = "Informe a descrição")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "Informe a ODS")]
    [Display(Name = "ODS")]
    public TipoODS ODS { get; set; }

    [Required(ErrorMessage = "Informe o número aproximado de voluntários")]
    [Display(Name = "Número de voluntários esperado")]
    public int NumVonlutarios { get; set; }

    [Required(ErrorMessage = "Informe o número de estimativa de pessoas alcançadas")]
    [Display(Name = "Número estimativa")]
    public int alcance { get; set; }

   

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


public enum Patrocinio
{
    Sim,
    Não
}
