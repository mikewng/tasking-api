using tasking_api.Main.Models;

namespace tasking_api.Main.Service.Contracts
{
    public interface ICalendarService
    {
        // Auth Connection
        public Task<Result<string>> GetAuthenticatedConnection();
        public Task<Result> HandleAuthenticationCallback(string code);

        // API Functions
        public Task<Result<string[]>> GetCalendarList();
        public Task<Result<string>> AddCalendar();
        public Task<Result<string>> AddEventToCalendar(string calendarId, string eventId);
        public Task<Result<string>> UpdateEventFromCalendar(string calendarId, string eventId);
        public Task<Result<string>> DeleteEventFromCalendar(int calendarId, string eventId);
    }
}
