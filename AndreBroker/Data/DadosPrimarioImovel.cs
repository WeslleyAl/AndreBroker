namespace AndreBroker.Data;

public class DadosPrimarioImovel
{
    public string Logradouro { get; set; }
    public string Complemento { get; set; }
    public int Numero { get; set; }
    public string Referência { get; set; }
    public string CEP { get; set; }
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

    public int AreaTotal { get; set; }
    public int AreaPrivativa { get; set; }

    public SituacaoImovelEnum SituacaoImovel { get; set; }
    public string NomeConstrutora { get; set; }
    public int AnoConstrucao { get; set; }
    public int AnoUltimaReforma { get; set; }

    public bool AceitaFinanciamento { get; set; }
    public bool EstudaPropostaPermuta { get; set; }
    public TipoCapitacaoEnum TipoCapitacao { get; set; }
    public bool Portaria24h { get; set; }
    public bool AceitaPet { get; set; }
    public float ValorVenda { get; set; }

    public string Descricao { get; set; }
}