using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProdutosAPI.Models
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public string Imagem { get; set; }

        public int Quantidade { get; set; }

        public decimal Valor { get; set; }

    }
}
