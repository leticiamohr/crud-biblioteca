using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDBiblioteca.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Column(TypeName = "varchar(250)")]
        [DisplayName("Título")]
        [Required(ErrorMessage = "Preenchimento obrigatório")]
        public string Title { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Autor")]
        [Required(ErrorMessage = "Preenchimento obrigatório")]
        public string Author { get; set; }

        [Column(TypeName = "varchar(80)")]
        [DisplayName("Gênero")]
        [Required(ErrorMessage = "Preenchimento obrigatório")]
        public string Genre { get; set; }

        [Column(TypeName = "varchar(80)")]
        [DisplayName("Classificação indicativa")]
        [Required(ErrorMessage = "Preenchimento obrigatório")]
        public string Classification { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Número de páginas")]
        [Required(ErrorMessage = "Preenchimento obrigatório")]
        public int NumPages { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Edição")]
        [Required(ErrorMessage = "Preenchimento obrigatório")]
        public int Edition { get; set; }

    }
}
