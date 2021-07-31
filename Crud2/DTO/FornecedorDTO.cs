using Crud2.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Crud2.DTO
{
    public class FornecedorDTO
    {
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa conter entre {1} caracters á {2} ", MinimumLength = 3)]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa conter entre {1} caracters á {2} ", MinimumLength = 11)]
        public string Documento { get; set; }

        public TipoFornecedor TipoFornecedor { get; set; }

        [DisplayName("Ativo ?")]
        public bool Ativo { get; set; }

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

    }
}
