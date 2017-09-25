using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;

namespace ElasticSearchAssignment
{
    public class ElasticSearch
    {
        ElasticClient client = null;
        public ElasticSearch()
        {
            var uri = new Uri("http://172.16.14.236:9200/");
            var settings = new ConnectionSettings(uri);
            client = new ElasticClient(settings);
            settings.DefaultIndex("hotel");
            client.Index("hotel");
        }
        //public List<Hotel> GetResult()
        //{
        //    if (client.IndexExists("hotel").Exists)
        //    {
        //        var response = client.Search<Hotel>();
        //        return response.Documents.ToList();
        //    }
        //    return null;
        //}

        public List<Hotel> GetResult(string condition)
        {
            
          
                var response = client.Search<Hotel>(s => s
                 .Index("hotel")
                 .Type("data")
                 .Query(q =>q.Match(x => x.Field("Name").Query(condition))));
                List<Hotel> list = new List<Hotel>();
            foreach (var hit in response.Hits)
            {
                var hotel = new Hotel();
                hotel.ID = hit.Source.ID;
                hotel.Name = hit.Source.Name;
                hotel.Country = hit.Source.Country;
                list.Add(hotel);
            }
            return list;
        }

        public void AddNewIndex(Hotel hotel)
        {
            client.Index<Hotel>(hotel, null);
        }
    }
}

