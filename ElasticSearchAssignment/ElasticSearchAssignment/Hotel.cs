using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticSearchAssignment
{
   public class Hotel
    {
        public string ID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public string Country
        {
            get;
            set;
        }

        public Hotel(string id, string name, string country)
        {
            this.ID = id;
            this.Name = name;
            this.Country = country;
        }
        public Hotel()
        {
                
        }
    }
}
