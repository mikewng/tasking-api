using tasking_api.Main.Models;
using tasking_api.Main.Service.Contracts;

namespace tasking_api.Main.Service
{
    public class GoogleCalendarService : ICalendarService
    {
        public Task<Result<string>> AddCalendar()
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> AddEventToCalendar(string calendarId, string eventId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> DeleteEventFromCalendar(int calendarId, string eventId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> GetAuthenticatedConnection()
        {
            throw new NotImplementedException();
        }

        public Task<Result<string[]>> GetCalendarList()
        {
            throw new NotImplementedException();
        }

        public Task<Result> HandleAuthenticationCallback(string code)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> UpdateEventFromCalendar(string calendarId, string eventId)
        {
            throw new NotImplementedException();
        }
    }
}
