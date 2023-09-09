using System.ComponentModel.DataAnnotations;

namespace RaptorsCoreRazor.Models
{
    public class Raptor
    {
        // Id is required by database for primary key
        public int Id { get; set; }

        [Range(1, 100)]
        [Required]
        [Display (Name = "Player Number")]
        public int PlayerNumber { get; set; }

        [Required]
        [StringLength (60, MinimumLength = 3)]
        [Display (Name = "Player Name")]
        public string? Name { get; set; }

        [Required]
        [StringLength (60, MinimumLength = 3)]
        [Display (Name = "Player Position")]
        public string? PlayerPosition { get; set; }

        [Required]
        [Display (Name = "Player Height")]
        public string? PlayerHeight { get; set; }

        [Range (1, 100000000)]
        [Required]
        [DataType(DataType.Currency)]
        [Display (Name = "Player Salary")]
        public double PlayerSalary  { get; set; }

        [StringLength (60, MinimumLength = 3)]
        [Display (Name = "College")]
        public string? PlayerCollege { get; set; }
    }
}
