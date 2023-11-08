using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AULA_25_05_2023_API_CODE_FIRST.Models
{
    [Table(name:"Atividade")]
    public class Atividade
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }

        [Column(name:"Nome")]
        [Required(ErrorMessage = "Informar o nome", AllowEmptyStrings = true)]
        [DataType(DataType.Text)]
        public string Nome { get; set; }
        
        [Column(name: "Tempo")]
        [Required(ErrorMessage = "Informar o tempo")]
        [Range(1,30,ErrorMessage = "")]
        public int Tempo { get; set; }

        
    }
}
