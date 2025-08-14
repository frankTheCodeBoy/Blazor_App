using EventEase.Models; 
public class EventService
{
    public Task<List<Event>> GetEventsAsync()
    {
        var mockEvents = new List<Event>
        {
            new Event { Id = 1, Name = "Tech Summit Nairobi", Date = DateTime.Today.AddDays(5), Location = "KICC" },
            new Event { Id = 2, Name = "Creative Expo", Date = DateTime.Today.AddDays(10), Location = "Sarit Centre" },
            new Event { Id = 3, Name = "Startup Mixer", Date = DateTime.Today.AddDays(15), Location = "iHub Nairobi" }
        };

        return Task.FromResult(mockEvents);
    }

    public Task<Event?> GetEventByIdAsync(int id)
    {
        var events = GetEventsAsync().Result;
        return Task.FromResult(events.FirstOrDefault(e => e.Id == id));
    }
}
