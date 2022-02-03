using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Produto : Entity
    {
        /*Em uma relação 1 para N, a chave estrangeira fica em N*/
        public Guid FornecedorId { get; set; } //Isto bastaria para um banco de dados, mas não para o EF

        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage ="O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }
        
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage ="O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }
        
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage ="O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Imagem { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        public decimal Valor { get; set; }
        
        public DateTime DataCadastro { get; set; }
        
        public bool Ativo { get; set; }

        /*EF Relations, é preciso colocar um campo fornecedor (além da foreignKey) para o EF*/
        public Fornecedor Fornecedor { get; set; } //Esta é uma propriedade de navegação do EF
    }
}
