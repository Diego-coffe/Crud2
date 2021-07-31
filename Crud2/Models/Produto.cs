using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crud2.Models
{
    public class Produto : Entity
    {

        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa conter entre {1} caracters á {2} ", MinimumLength = 3)]
        public string Nome { get; set; }


        [Required(ErrorMessage ="O campo {0} é obrigatorio")]
        [StringLength(500, ErrorMessage ="O campo {0} precisa conter entre {1} caracters á {2} ", MinimumLength = 3)]
        public string Descricao { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Imagem { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public decimal Valor { get; set; }


        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        /*Relaçao para ORM (Entity Framework)  1 x N */

        public Fornecedor Fornecedor { get; set; }

    }
}
