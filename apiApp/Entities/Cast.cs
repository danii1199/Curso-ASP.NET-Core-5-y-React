using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiApp.Entities
{
    public class Cast
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required()]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required()]
        [MaxLength(50)]
        public string Character { get; set; }

        [ForeignKey("MovieId")]
        public Movie movie { get; set; }

        public int MovieId { get; set; }

        public int? Age { get; set; }
    }
}