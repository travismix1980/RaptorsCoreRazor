namespace RaptorsCoreRazor.Models
{
    public class Raptor
    {
        // Id is required by database for primary key
        public int Id { get; set; }
        public int PlayerNumber { get; set; }
        public string? Name { get; set; }
        public string? PlayerPosition { get; set; }
        public string? PlayerHeight { get; set; }
        public double PlayerSalary  { get; set; }
    }
}
