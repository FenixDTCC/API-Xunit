using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuantoDemoraApi.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Cpf { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [NotMapped]
        public Associado Associado { get; set; }
        public int? IdAssociado { get; set; }
        public DateTime? DtAcesso { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string TpUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        [NotMapped]
        public string PasswordString { get; set; }
        [NotMapped]
        public string Token { get; set; }
    }
}