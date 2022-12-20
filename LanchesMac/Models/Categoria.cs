using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100,ErrorMessage ="O tamanho maximo é de 100 caracteres")]
        [Required(ErrorMessage ="INforme o nome da categoria")]
        [Display(Name ="Nome")]
        public string Nome { get; set; }
        [StringLength(200, ErrorMessage = "O tamanho maximo é de 200 caracteres")]
        [Required(ErrorMessage = "INforme a descricao da categoria")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
