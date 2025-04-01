namespace eCommerce2.Models.FluentAPI
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public ICollection<Usuario>? Usuarios { get; set; }
    }
}