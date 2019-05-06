using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

using IptvPlaylistAggregator.Configuration;
using IptvPlaylistAggregator.DataAccess.DataObjects;

namespace IptvPlaylistAggregator.DataAccess.Repositories
{
    public sealed class ChannelDefinitionRepository : IChannelDefinitionRepository
    {
        const string UnknownGroupPlaceholder = "unknown";

        readonly ApplicationSettings settings;

        public ChannelDefinitionRepository(ApplicationSettings settings)
        {
            this.settings = settings;
        }

        public IEnumerable<ChannelDefinitionEntity> GetAll()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<ChannelDefinitionEntity>));
            IEnumerable<ChannelDefinitionEntity> entities;

            using (TextReader reader = new StreamReader(settings.ChannelStorePath))
            {
                entities = (IEnumerable<ChannelDefinitionEntity>)serializer.Deserialize(reader);
            }

            foreach (ChannelDefinitionEntity channelDef in entities)
            {
                if (string.IsNullOrWhiteSpace(channelDef.GroupId))
                {
                    channelDef.GroupId = UnknownGroupPlaceholder;
                }
            }

            return entities;
        }
    }
}
