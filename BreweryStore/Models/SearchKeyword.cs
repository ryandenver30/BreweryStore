using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BreweryStore.Models
{
    public class SearchKeyword
    {
        public string KeyWord { get; set; }
        public string CityName { get; set; }
        public BreweryDTO[] Breweries { get; set; }

        
    }
}