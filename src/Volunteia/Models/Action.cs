using System; // Necessário para usar tipos como DateTime
using System.Collections.Generic; // Necessário para usar List<T>
using System.ComponentModel.DataAnnotations; // Necessário para anotações de validação
using System.ComponentModel.DataAnnotations.Schema; // Necessário para a configuração da tabela

// Namespace que organiza as classes relacionadas ao modelo da aplicação
namespace Volunteia.Models
{  

    // Classe que representa uma ação no sistema
    [Table("Actions")] // Define o nome da tabela no banco de dados
    public class Action
    {
        [Key] // Define a propriedade como chave primária
        public int ActionId { get; set; } // Identificador único da ação

        [ForeignKey("User")] // Define a relação de chave estrangeira com a tabela de Usuários
        public int UserId { get; set; } // Identificador do usuário associado à ação
        public User User { get; set; } // Propriedade de navegação para o usuário

        [Required(ErrorMessage = "Selecione uma foto para a ação")] // Validação obrigatória
        [Display(Name = "Foto")] // Nome que será exibido na interface
        public byte[] Foto { get; set; } // Foto da ação

        [Required(ErrorMessage = "Informe o nome")] // Validação obrigatória
        [Display(Name = "Nome")] // Nome a ser exibido
        public string Name { get; set; } // Nome da ação

        public bool Patrocinador { get; set; } // Indica se a ação tem patrocinador

        [Required(ErrorMessage = "Informe a data")] // Validação obrigatória
        public DateTime ActionDate { get; set; } // Data da ação

        [Required(ErrorMessage = "Informe a descrição")] // Validação obrigatória
        [Display(Name = "Descrição")] // Nome a ser exibido
        public string ActionBio { get; set; } // Descrição da ação

        [Required(ErrorMessage = "Informe a ODS")] // Validação obrigatória
        [Display(Name = "ODS")] // Nome a ser exibido
        public TipoODS ODS { get; set; } // Objetivo de Desenvolvimento Sustentável associado

        [Required(ErrorMessage = "Informe o número aproximado de voluntários")] // Validação obrigatória
        [Display(Name = "Número de voluntários esperado")] // Nome a ser exibido
        public int VolunteersTotal { get; set; } // Número total de voluntários esperados

        [Required(ErrorMessage = "Informe o número de estimativa de pessoas alcançadas")] // Validação obrigatória
        [Display(Name = "Número estimativa")] // Nome a ser exibido
        public int Alcance { get; set; } // Número estimado de pessoas alcançadas
    }
    // Enumeração que representa os possíveis estados de uma ação
    public enum ActionStatus
    {
        // Estado que indica que a ação está atualmente em andamento e aceita novos participantes
        Ativa,

        // Estado que indica que a ação foi concluída e não está mais em execução
        Concluída,

        // Estado que indica que a ação foi cancelada e não ocorrerá
        Cancelada
    }

    // Enumeração que representa os Objetivos de Desenvolvimento Sustentável (ODS)
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
}
