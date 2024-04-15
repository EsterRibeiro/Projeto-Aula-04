using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Entities;
/// <summary>
/// Modelo de entidade de domínio
/// </summary>
public class Pessoa
{
    #region Propriedades

    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }

    #endregion
}
