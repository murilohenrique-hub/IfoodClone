using System.ComponentModel.DataAnnotations;

namespace IfoodClone.Models
{
    public class Refeicao
    {
        public int Id { get; set; }
        public int RestauranteId { get; set; }
        [Required, StringLength(120)] public string Nome { get; set; } = "";
        [StringLength(400)] public string? Descricao { get; set; }
        [Range(0.01, 9999)] public decimal PrecoBase { get; set; }
        public string? Categoria { get; set; }
        public bool Disponivel { get; set; } = true;
        public string? UrlImagem { get; set; }
    }
}
