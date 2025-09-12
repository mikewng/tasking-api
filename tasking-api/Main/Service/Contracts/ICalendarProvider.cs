using tasking_api.Main.Models;

namespace tasking_api.Main.Service.Contracts
{
    public interface ICalendarProvider
    {
        public string ProviderKey { get; }
    }
}
