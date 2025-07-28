namespace ConsoleApp1.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Title { get; set; }
        public int SpecId { get; set; }
        // Add navigation properties if needed
    }
}
