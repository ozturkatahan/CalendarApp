namespace CalendarApp.Models.Entities
{
    public class Reservations
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string RezName { get; set; }
        public int RezNo { get; set; }
        public DateTime RezDate { get; set; }
        public ICollection<ReservationType> RezervationTypes { get; set; }
    }
}
