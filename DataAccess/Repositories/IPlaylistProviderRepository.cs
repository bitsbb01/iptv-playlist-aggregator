using System.Collections.Generic;

using IptvPlaylistAggregator.DataAccess.DataObjects;

namespace IptvPlaylistAggregator.DataAccess.Repositories
{
    public interface IPlaylistProviderRepository
    {
        IEnumerable<PlaylistProviderEntity> GetAll();
    }
}
