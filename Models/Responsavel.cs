using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_BackEnd_Final.Models
{
    public class Responsavel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Endereco { get; set; }
        public TipoResponsavelEnum TipoFuncionario { get; set; }

        public TipoResponsavelEnum tipoResponsavel { get; set; }

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
            if(ContarCaracteres(Cpf) ==11)
            return true;
            else 
            return false;
        }

    }
}