namespace eCommerce.Office.Models
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public ICollection<Veiculo>? Veiculos { get; set; }
        public ICollection<ColaboradorSetor>? ColaboradorSetores { get; set; }
        public ICollection<Setor>? Setores { get; set; }
        public ICollection<Turma>? Turmas { get; set; }
    }
}
