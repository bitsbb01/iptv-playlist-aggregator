using System.Collections.Generic;

using IptvPlaylistFetcher.DataAccess.DataObjects;

namespace IptvPlaylistFetcher.DataAccess.Repositories
{
    public interface IChannelDefinitionRepository
    {
        IEnumerable<ChannelDefinitionEntity> GetAll();
    }
}