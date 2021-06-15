using System;
using System.Collections.Generic;

namespace codigo.prodiccion
{
    public class clsUrlToStringParser
    {
        public IDictionary<string, string> parseUrl(string urlToParse)
        {
            Chilkat.Url url = new Chilkat.Url();
            
            bool success = url.ParseUrl(urlToParse);
            string[] protocol = urlToParse.Split(":");
            string URL = urlToParse;
            string Scheme = protocol[0];
            
            string Host = url.Host;
            string Port = (url.Port).ToString();
            string Path = url.Path;
            string Query = url.Query;
            string Frag = url.Frag;
            
            var parsedUrl = new Dictionary<string, string>(){
                
                {"Scheme", Scheme},
                {"Host", Host},
                {"Port", Port},
                {"Path", Path},
                {"Query", Query},
                {"Fragment", Frag},
            };
            
            return parsedUrl;
            
        }
    }

}