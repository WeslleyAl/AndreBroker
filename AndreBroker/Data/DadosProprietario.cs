using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace AndreBroker.Data;

public class DadosProprietario
{
    public string Nome { get; set; }
    public bool ImovelEmSeuNome { get; set; } = true;
    public string NomeProprietario { get; set; }
    public bool AutorizacaoVenda { get; set; }
    public string Telefone { get; set; }
    public string Celular { get; set; }
    public bool IsWhatsApp { get; set; } = true;
    public TipoTelefoneEnum TipoTelefone { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }
    public bool Exclusividade { get; set; }
}

public class DadosProprietarioValidator: AbstractValidator<DadosProprietario>
{
    public DadosProprietarioValidator()
    {
        RuleFor(obj => obj.Nome)
        .NotEmpty().WithMessage("Informe o seu nome completo");

        RuleFor(obj => obj.NomeProprietario)
        .NotEmpty().When(obj => !obj.ImovelEmSeuNome).WithMessage("Informe o nome completo do proprietário");

        RuleFor(obj => obj.Celular)
        .NotEmpty().WithMessage("Informe um número de celular válido");
    }
}