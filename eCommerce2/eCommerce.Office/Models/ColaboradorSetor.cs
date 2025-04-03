namespace eCommerce.Office.Models
{
    public class ColaboradorSetor
    {
        public int ColaboradorId { get; set; }
        public int SetorId { get; set; }
        public Colaborador? Colaborador { get; set; }
        public Setor? Setor { get; set; }
    }
}
