using Microsoft.Extensions.Options;

namespace Less15_API_6._0_
{
    public class RoomService
    {
        private readonly ServerSettings _settings;
        public RoomService(IOptions<ServerSettings> opts)
        {
            _settings = opts.Value;
        }

        public string GetDescription()
        {
            return $"Max meeting time (minutes): {_settings.MaxMeetingTimeMins}, Capacity: {_settings.MaxUsersPerRoom}, Amount of rooms: {_settings.MaxRooms}";
        }
    }
}
