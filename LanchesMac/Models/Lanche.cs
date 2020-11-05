using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        public int LancheId { get; set; }

        [Required]
        [Display(Name = "Nome do Lanche")]
        [StringLength(80, MinimumLength = 10)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20)]
        [MaxLength(200)]
        public string DescricaoCurta { get; set; }

        [Required]
        [Display(Name = "Descrição detalhada do Lanche")]
        [MinLength(20)]
        [MaxLength(200)]
        public string DescricaoDetalhada { get; set; }

        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200)]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200)]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
