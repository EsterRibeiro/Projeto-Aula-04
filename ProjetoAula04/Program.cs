// See https://aka.ms/new-console-template for more information
using ProjetoAula04.Entities;
using ProjetoAula04.Validations;

var pessoa = new Pessoa();

pessoa.Id = Guid.NewGuid();

Console.WriteLine("Nome:");
pessoa.Nome = Console.ReadLine();

Console.WriteLine("Email: ");
pessoa.Email = Console.ReadLine();

Console.WriteLine("CPF: ");
pessoa.Cpf = Console.ReadLine();

var pessoaValidation = new PessoaValidation();
var result = pessoaValidation.Validate(pessoa); //aplicando a validação

//verificar se ps dados passaram na validação
if (result.IsValid)
    Console.WriteLine("Dados preenchidos com sucesso");
else
{
    Console.WriteLine("Ocorreram erros de validação");
    //exibir todas as mensagens de erro de validação
    foreach (var validation in result.Errors)
    {
        Console.WriteLine(validation.ErrorMessage);
    }
}