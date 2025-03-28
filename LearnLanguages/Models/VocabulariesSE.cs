using System.ComponentModel.DataAnnotations;

namespace LearnLanguages.Models
{
    public class VocabulariesSE
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string Translation { get; set; }
    }
}
