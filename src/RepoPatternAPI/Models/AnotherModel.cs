using GenericProjectAPI.Data;
using System.ComponentModel.DataAnnotations;

namespace GenericProjectAPI.Models
{
    public class AnotherModel : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Name { get; set; } = String.Empty;

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string NickName { get; set; } = String.Empty;

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Nationality { get; set; } = String.Empty;

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public bool Single { get; set; }
    }
}
