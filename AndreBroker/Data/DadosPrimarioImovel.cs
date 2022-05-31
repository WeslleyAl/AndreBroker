using FluentValidation;

namespace AndreBroker.Data;

public class DadosPrimarioImovel
{
    public string Logradouro { get; set; }
    public string Complemento { get; set; }
    public string Numero { get; set; }
    public string Referencia { get; set; }
    public string CEP { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }

    public FinalidadeImovelEnum Finalidade { get; set; }
    public TipoImovelEnum Tipo { get; set; }
    public string NomeCondominio { get; set; }
    public PosicaoSolEnum PosicaoSol { get; set; }
    public PosicaoImovelEnum PosicaoImovel { get; set; }

    public string MatriculaImovel { get; set; }
    public string IPTUMatricula { get; set; }
    public float IPTUValor { get; set; }
    public TipoValorEnum TipoValor { get; set; }

    public int AreaTotal { get; set; }
    public int AreaPrivativa { get; set; }

    public SituacaoImovelEnum SituacaoImovel { get; set; }
    public string NomeConstrutora { get; set; }
    public int AnoConstrucao { get; set; }
    public int AnoUltimaReforma { get; set; }

    public bool AceitaFinanciamento { get; set; }
    public bool EstudaPropostaPermuta { get; set; }
    //public TipoCaptacaoEnum TipoCapitacao { get; set; }
    public bool TipoCaptacaoVenda { get; set; }
    public bool TipoCaptacaoLocacao { get; set; }
    public bool Portaria24h { get; set; }
    public bool AceitaPet { get; set; }
    public float ValorVenda { get; set; }
    public float Comissao { get; set; }

    public string Descricao { get; set; }
}

public class DadosPrimarioImovelValidator : AbstractValidator<DadosPrimarioImovel>
{
    public DadosPrimarioImovelValidator()
    {
        RuleFor(obj => obj.CEP)
        .NotEmpty().WithMessage("Informe um CEP válido");

        RuleFor(obj => obj.Numero)
        .NotEmpty().WithMessage("Informe o número do imóvel");

        RuleFor(obj => obj.IPTUValor)
        .GreaterThan(0).WithMessage("Informe um valor para o IPTU");

        RuleFor(obj => obj.AreaPrivativa)
        .GreaterThan(0).WithMessage("Informe quantos M2 de área privativa o imóvel possui");

        RuleFor(obj => obj.ValorVenda)
        .GreaterThan(0).WithMessage("Informe o valor de venda");
    }
}