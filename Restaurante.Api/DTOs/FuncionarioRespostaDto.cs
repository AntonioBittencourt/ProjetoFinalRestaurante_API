using SimuladorBancoDados;

namespace Restaurante.Api.DTOs
{
    public class FuncionarioRespostaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }
        public Funcao Funcao { get; set; }
        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
