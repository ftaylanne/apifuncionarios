using System.ComponentModel.DataAnnotations;

namespace ApiFuncionarios.Services.Requests
{
    /// <summary>
    /// Modelo de dados para a requisição de cadastro de funcionário
    /// </summary>
    public class FuncionarioPostRequest
    {
        [Required(ErrorMessage = "Por favor, informe o nome do funcionário.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe a matrícula.")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Por favor, informe o cpf.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de admissão.")]
        public DateTime DataAdmissao { get; set; }
    }
}