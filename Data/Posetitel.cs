namespace VistavkaApp.Data
{
    public class Posetitel
    {
        public int PosetitelId { get; set; }
        public string? PosetitelName { get; set; }
        public string? PosetitelSurname { get; set; }
        public DateTime? DateBirth { get; set; }
        public int Phone { get; set; }
        public string? Email { get; set; }
        public virtual ICollection<Bilet>? Bilets { get; set; }
    
    }
}
