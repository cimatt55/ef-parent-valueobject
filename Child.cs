using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NestedValueObject
{
    public class Child
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; protected set; }

        [Required]
        public int ParentId { get; private set; }

        [ForeignKey("ParentId")]
        public Parent Parent { get; private set; }
    }
}
