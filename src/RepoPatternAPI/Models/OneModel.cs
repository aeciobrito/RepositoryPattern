using GenericProjectAPI.Data;
using System.ComponentModel.DataAnnotations;

namespace GenericProjectAPI.Models
{
    public class OneModel : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; } = String.Empty;             

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
