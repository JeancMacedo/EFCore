﻿namespace eCommerce.Office.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Placa { get; set; } = null!;
        public ICollection<Colaborador>? Colaboradores { get; set; }
    }
}
