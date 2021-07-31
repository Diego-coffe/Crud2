using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crud2.Models
{
    public class Endereco : Entity
    {

        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa conter entre {1} caracters á {2} ", MinimumLength = 3)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa conter entre {1} caracters á {2} ", MinimumLength = 3)]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(8, ErrorMessage = "O campo {0} precisa conter entre {1} caracters á {2} ", MinimumLength = 8)]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa conter caracters {1} ", MinimumLength = 8)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa conter entre {1} caracters á {2} ", MinimumLength = 3)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa conter entre {1} caracters á {2} ", MinimumLength = 3)]
        public string Estado { get; set; }



        /* Relação para ORM (Entity Framework) 1 x 1 */
        public Fornecedor Fornecedor { get; set; }
    }
}
