public class EventService
{
    private List<Event> events = new()
    {
        new Event { Id = 1, Name = "Music Fest", Date = DateTime.Today.AddDays(5), Location = "Rome", Description = "Outdoor concert with live bands." },
        new Event { Id = 2, Name = "Tech Conference", Date = DateTime.Today.AddDays(10), Location = "Milan", Description = "Talks and workshops on innovation." }
    };

    public List<Event> GetEvents() => events;

    public Event? GetEventById(int id) => events.FirstOrDefault(e => e.Id == id);
}
