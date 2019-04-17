using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace BreweryStore.Models
{
    public class Brewery
    {
        public Object getAutoCompleteData(string searchKeyword)
        {
            string url = "https://api.openbrewerydb.org/breweries/autocomplete?query=" + searchKeyword;
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }

        public Object getBreweryByName(string name)
        {
            string url = "https://api.openbrewerydb.org/breweries?by_name=" + name;
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }

        public Object getBreweryByState(string name)
        {
            string url = "https://api.openbrewerydb.org/breweries?by_state=" + name;
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }

        public Object getBreweryByNameAndState(string name,string state)
        {
            string url = "https://api.openbrewerydb.org/breweries?by_name="+name+"&by_state=" + state;
            //synchronous client.
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}