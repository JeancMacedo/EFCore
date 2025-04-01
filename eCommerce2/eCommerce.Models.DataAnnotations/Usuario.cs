using eCommerce.Models.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce2.Models
{
    //nameof(Email) = "Email"
    [Index(nameof(Email), IsUnique = true, Name = "IX_EMAIL_UNICO")]
    [Index(nameof(Nome), nameof(CPF))]
    [Table("TB_USUARIOS")]
    public class Usuario
    {
        //Convensão Id - UsuarioId = PK - Identity
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        //[Key]
        //[Column("COD")]
        //public int Codigo { get; set; }

        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Sexo { get; set; }

        [Column("REGISTRO_GERAL")]
        public string? RG { get; set; }
        public string CPF { get; set; } = null!;
        public string? NomeMae { get; set; }
        public string? SituacaoCadastro { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Matricula { get; set; }

        [NotMapped]
        public bool RegistroAtivo { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTimeOffset DataCadastro { get; set; } // "GetDate()"
        [ForeignKey("UsuarioId")]
        public Contato? Contato { get; set; }
        public ICollection<EnderecoEntrega>? EnderecosEntrega { get; set; }
        public ICollection<Departamento>? Departamentos { get; set; }

        /*
         * * PedidosCompradosPeloCliente
         * - ClientId*
         * - ColaboradorId
         * - SupervisorId
         * 
         * * PedidosGerenciadosPeloColaborador 
         * - ClientId
         * - ColaboradorId*
         * - SupervisorId
         * 
         * * PedidosSupervisionadosPeloColaboradorSuperior
         * - ClientId
         * - ColaboradorId
         * - SupervisorId*
         */


        [InverseProperty("Cliente")]
        public ICollection<Pedido>? PedidosCompradosPeloClient { get; set; }

        [InverseProperty("Colaborador")]
        public ICollection<Pedido>? PedidosGerenciadosPeloColaborador { get; set; }

        [InverseProperty("Supervisor")]
        public ICollection<Pedido>? PedidosSupervisionadosPeloColaboradorSuperior { get; set; }


    }
}
