using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce2.Models
{
    public class Contato
    {
        public int Id { get; set; }

        public string? Telefone { get; set; }
        public string? Celular { get; set; }
        /*
         * Coluna - MER
         * Convensão: {Modelo}+{PK} = UsuarioId
         */
        /*
         * UsuarioId(MER) - FK(Propriedade do POO)
        [ForeignKey("Usuario")]
        */
        public int TBUsuarioId { get; set; }
        /*
         * POO (Navegar)
         * [ForeignKey("UsuarioId")]
         */

        public Usuario? Usuario { get; set; } 
    }
}