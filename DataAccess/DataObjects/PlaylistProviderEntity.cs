using NuciDAL.DataObjects;

namespace IptvPlaylistAggregator.DataAccess.DataObjects
{
    public class PlaylistProviderEntity : EntityBase
    {
        public bool IsEnabled { get; set; }

        public int Priority { get; set; }

        public bool AllowCaching { get; set; }

        public string Name { get; set; }

        public string UrlFormat { get; set; }

        public string Country { get; set; }

        public string ChannelNameOverride { get; set; }

        public PlaylistProviderEntity()
        {
            Priority = int.MaxValue;
            AllowCaching = true;
        }
    }
}
