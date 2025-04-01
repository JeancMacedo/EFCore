namespace eCommerce2.Models.FluentAPI
{
    public class EnderecoEntrega
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string NomeEndereco { get; set; } = null!;
        public string CEP { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Cidade { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string Endereco { get; set; } = null!;
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public Usuario? Usuario { get; set; }

    }
}
