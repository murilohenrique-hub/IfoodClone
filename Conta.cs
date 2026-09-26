using System.ComponentModel.DataAnnotations;

namespace IfoodClone.Models
{
    public class Conta
    {
        public int Id { get; set; }
        [Required, StringLength(120)] public string Nome { get; set; } = "";
        [Required, EmailAddress] public string Email { get; set; } = "";
        public string? SenhaHash { get; set; }
        public string? Telefone { get; set; }
        public string Papel { get; set; } = "CLIENTE";
        public string? Provider { get; set; }
        public string? ProviderId { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime CriadoEm { get; set; } = DateTime.Now;
    }
}
