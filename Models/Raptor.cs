using System.ComponentModel.DataAnnotations;

namespace RaptorsCoreRazor.Models
{
    public class Raptor
    {
        // Id is required by database for primary key
        public int Id { get; set; }

        [Display (Name = "Player Number")]
        public int PlayerNumber { get; set; }

        [Display (Name = "Player Name")]
        public string? Name { get; set; }

        [Display (Name = "Player Position")]
        public string? PlayerPosition { get; set; }

        [Display (Name = "Player Height")]
        public string? PlayerHeight { get; set; }

        [Display (Name = "Player Salary")]
        public double PlayerSalary  { get; set; }
    }
}
