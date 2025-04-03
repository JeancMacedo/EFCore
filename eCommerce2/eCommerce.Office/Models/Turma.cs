namespace eCommerce.Office.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public ICollection<Colaborador>? Colaboradores { get; set; }
    }
}
