namespace VistavkaApp.Data
{
    public class Vistavka
    {
        public int VistavkaId { get; set; }
        public string? VistavkaName { get; set; }
        public string? Description { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string? Place { get; set; }
        public virtual ICollection<Bilet>? Bilets { get; set; }

    }
}
