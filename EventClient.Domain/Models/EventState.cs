using EventClient.Domain.Enums;

namespace EventClient.Domain.Models
{
    public class EventState
    {
        public StateType State { get; set; }
        public DateTime LastUpdateState { get; set; }
    }
}
