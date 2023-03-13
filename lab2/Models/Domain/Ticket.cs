
using lab2.Models.View;

namespace lab2.Models.Domain
{
    public class Ticket
    {
        public Guid Id { get; set; }

        public DateOnly CreatedDate { get; set; }
        public bool IsClosed { get; set; }
        public Severities Severity { get; set; }
        public string? Description { get; set; }

        private static List<Ticket> _tickets = new(){};
        public static void AddtoTickets(TicketVM t) {
            Ticket ticket = new Ticket(t.CreatedDate, t.IsClosed, t.Severity, t.Description);
            _tickets.Add(ticket);
        }
        public static List<Ticket> GetTickets()
        {
            return _tickets;
        }

        public Ticket()
        {
            Id = Guid.NewGuid();
        }
        public Ticket(DateOnly createdDate, bool isClosed, Severities severity, string? description)
        {
            Id = Guid.NewGuid();
            CreatedDate = createdDate;
            IsClosed = isClosed;
            Severity = severity;
            Description = description;
        }
    }
}
