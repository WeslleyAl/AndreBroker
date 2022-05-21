using FluentValidation;

namespace AndreBroker.Data;

public class DadosEstruturaisImovel
{
    public int QuantidadeQuartos { get; set; }
    public int QuantidadeSuites { get; set; }
    public bool PossuiCloset { get; set; }
    public bool PossuiComodoReversivel { get; set; }
    public bool ComodoReversivelSala { get; set; }
    public bool ComodoReversivelQuarto { get; set; }
    public bool ComodoReversivelBanheiro { get; set; }
    public int QuantidadeBanheiros { get; set; }
    public bool PossuiLavabo { get; set; }
    public bool PossuiHidromassagem { get; set; }
    public int QuantidadeSalas { get; set; }
    public bool PossuiVaranda { get; set; }
    public bool PossuiSacada { get; set; }
    public bool PossuiVarandaGourmet { get; set; }
    public TipoCozinhaEnum TipoCozinha { get; set; }
    public bool PossuiDependenciaQuarto { get; set; }
    public bool PossuiDependenciaBanheiro { get; set; }
    public bool PossuiDespensa { get; set; }
    public bool PossuiAreaServico { get; set; }
    public string TipoPiso { get; set; }

    public bool PossuiAguaAquecidaAGas { get; set; }
    public bool PossuiArmarioEmbutidoSala { get; set; }
    public bool PossuiArmarioEmbutidoQuarto { get; set; }
    public bool PossuiArmarioEmbutidoBanheiro { get; set; }
    public bool PossuiArmarioEmbutidoDespensa { get; set; }
    public bool PossuiArmarioEmbutidoCozinha { get; set; }
    public bool PossuiArmarioEmbutidoEscritorio { get; set; }

    public bool PossuiArCondicionadoSala { get; set; }
    public bool PossuiArCondicionadoQuarto { get; set; }
    public bool PossuiArCondicionadoBanheiro { get; set; }
    public bool PossuiArCondicionadoDespensa { get; set; }
    public bool PossuiArCondicionadoCozinha { get; set; }
    public bool PossuiArCondicionadoEscritorio { get; set; }

    public int QuantidadeVagas { get; set; }
    public bool PossuiVagaCoberta { get; set; }
    public bool PossuiVagaSolta { get; set; }
    public bool PossuiVagaNaEscritura { get; set; }
    public CaracteristicaVagaEnum CaracteristicaVaga { get; set; }

    public bool PossuiAreaLazer { get; set; }
    public bool PossuiPiscina { get; set; }
    public bool PossuiChurrasqueira { get; set; }
    public bool PossuiSauna { get; set; }
    public bool PossuiCampoEsporte { get; set; }
    public bool PossuiPlayground { get; set; }
    public bool PossuiQuintal { get; set; }
    public bool PossuiSalaoFesta { get; set; }
    public bool PossuiAcademia { get; set; }
    public bool PossuiBrinquedoteca { get; set; }

    public bool AceitaVisitaFotoFilmagem { get; set; }

    public string IPTU_File { get; set; }
    public string Escritura_File { get; set; }
    public string Espelho_File { get; set; }

    public bool AutorizoIntermediacao { get; set; }
}

public class DadosEstruturaisImovelValidator : AbstractValidator<DadosEstruturaisImovel>
{
    public DadosEstruturaisImovelValidator()
    {
        RuleFor(obj => obj.AutorizoIntermediacao)
        .Equal(true).WithMessage("É necessário autorizar a intermediação do imóvel");
    }
}