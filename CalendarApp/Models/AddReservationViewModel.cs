using CalendarApp.Models.Entities;

namespace CalendarApp.Models
{
    public class AddReservationViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string RezName { get; set; }
        public int RezNo { get; set; }
        public DateTime RezDate { get; set; }
        public ICollection<ReservationType> RezervationTypes { get; set; }
    }
}
