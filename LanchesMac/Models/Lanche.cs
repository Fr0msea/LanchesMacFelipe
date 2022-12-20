using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Models
{
    [Table("Lanches")]

    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }
        [StringLength(80,MinimumLength =10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2} caracteres")]
        [Required(ErrorMessage = "Nome do lanche deve ser informado")]
        [Display(Name = "Nome do Lanche")]
        public string Nome { get; set; }
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2} caracteres")]
        [Required(ErrorMessage = "Descricao do lanche deve ser informado")]
        [Display(Name = "Descricao do Lanche")]
        public string DescricaoCurta { get; set; }
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2} caracteres")]
        [Required(ErrorMessage = "Descricao Detalhada do lanche deve ser informado")]
        [Display(Name = "Descricao Detalhada do Lanche")]
        public string DescricaoDetalhada { get; set; }
        [Required(ErrorMessage = "Preço do lanche deve ser informado")]
        [Column(TypeName ="decimal(10,2)")]
        [Display(Name = "Preço")]
        [Range(1,999.99, ErrorMessage = "Preço do lanche deve ser entre 1 e 1000")]
        public decimal Preco { get; set; }
        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracteres")]

        public string ImagemUrl { get; set; }
        [Display(Name = "Caminho Imagem Pequena")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracteres")]


        public string ImagemThumbnailUrl { get; set; }
        [Display(Name = "Preferido?")]

        public bool IsLanchePreferido { get; set; }
        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }






    }
}
