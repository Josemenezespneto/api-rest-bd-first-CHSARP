using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AULA_25_05_2023_API_CODE_FIRST.Models
{
    [Table(name: "Treino")]
    public class Treino
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }

        [Column(name: "Nome")]
        [Required(ErrorMessage = "Informar o nome")]
        public string Nome { get; set; }

        public List<Atividade> Atividades { get; set; }

    }
}
