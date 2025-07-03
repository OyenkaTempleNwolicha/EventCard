public class AttendanceService
{
    private List<UserRegistration> attendees = new();

    public void RegisterAttendance(UserRegistration user)
    {
        attendees.Add(user);
    }

    public List<UserRegistration> GetAttendees(int eventId) =>
        attendees.Where(a => a.EventId == eventId).ToList();
}
