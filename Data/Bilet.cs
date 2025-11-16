namespace VistavkaApp.Data
{
    public class Bilet
    {
        public int BiletId { get; set; }
        public int? PosetitelId { get; set; }
        public int? VistavkaId { get; set; }
        public DateTime? DateVisit { get; set; }
        public int Price { get; set; }
        public virtual Posetitel? Posetitel { get; set; }
        public virtual Vistavka? Vistavka { get; set; }

    }
}
