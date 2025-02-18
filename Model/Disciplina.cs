using System.ComponentModel.DataAnnotations;

namespace APITATT1.Model
{
    public class Disciplina
    {
        [Key]
        public int id { get; set; }

        [StringLength(35)]
        public string nome { get; set; }
    }
}
