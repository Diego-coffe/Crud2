using Crud2.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crud2.Models
{
    public class Fornecedor : Entity
    {

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa conter entre {1} caracters á {2} ", MinimumLength = 3)]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa conter entre {1} caracters á {2} ", MinimumLength = 11)]
        public string Documento { get; set; }

        public TipoFornecedor TipoFornecedor { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa conter entre {1} caracters á {2} ", MinimumLength = 3)]
        public Endereco Endereco { get; set; }


        [DisplayName("Ativo ?")]
        public bool Ativo { get; set; }


        /*Relacao para ORM (Entity Framework) N x N */

        public IEnumerable<Produto> Produtos { get; set; }
    }
}
