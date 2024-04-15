using FluentValidation;
using ProjetoAula04.Entities;

namespace ProjetoAula04.Validations;

/// <summary>
/// classe de mapeamento de validação para a entidade pessoa
/// </summary>
public class PessoaValidation : AbstractValidator<Pessoa>
{
    //método construtor
    public PessoaValidation()
    {
        RuleFor(pessoa => pessoa.Id).NotEmpty().WithMessage("Informe o ID da pessoa");

        RuleFor(pessoa => pessoa.Nome).NotEmpty().WithMessage("Informe o nome da pessoa")
            .Length(8, 100).WithMessage("Informe o nome entre 8 e 100 caracteres");

        RuleFor(pessoa => pessoa.Email).NotEmpty().WithMessage("Informe o e-mail da pessoa")
            .EmailAddress().WithMessage("Informe um endereço de e-mail válido");

        RuleFor(pessoa => pessoa.Cpf).NotEmpty().WithMessage("Informe o CPF da pessoa")
            .Matches("^[0-9]{11}$").WithMessage("Informe exatamente 11 números para o CPF");
    }
}
