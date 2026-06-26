namespace Projeto_BackEnd_Final.Models
{
    public class Responsavel
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }
        public string Endereco { get; set; } = string.Empty;

        public TipoResponsavelEnum TipoResponsavel { get; set; }

        public string IdentificarResponsavel()
        {
            return $"{Nome} é o responsável legal do paciente.";
        }

        private int ContarCaracteres(string dado)
        {
            return dado.Length;
        }

        public bool ValidaCpf()
        {
            return ContarCaracteres(Cpf) == 11;
        }
    }
}