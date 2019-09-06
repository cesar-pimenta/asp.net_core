using System.Collections.Generic;

namespace core.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<Atributo> Atributos { get; set;}

    }
}