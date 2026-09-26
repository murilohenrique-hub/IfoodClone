using System.ComponentModel.DataAnnotations;

namespace IfoodClone.Models
{
    public class Restaurante
    {
        public int Id { get; set; }
        [Required, StringLength(120)] public string Nome { get; set; } = "";
        [Required, StringLength(18)] public string Cnpj { get; set; } = "";
        [Required] public string Categoria { get; set; } = "";
        [Range(0, 9999)] public decimal TaxaEntrega { get; set; }
        [Range(0, 9999)] public decimal PedidoMinimo { get; set; }
        public bool Ativo { get; set; } = true;
        public int ContaId { get; set; }
    }
}
