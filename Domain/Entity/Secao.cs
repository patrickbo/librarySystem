using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("secao", Schema = "books")]
    public class Secao
    {
        public long? Id { get; set; }
        public string Name { get; set; }         
    }
}