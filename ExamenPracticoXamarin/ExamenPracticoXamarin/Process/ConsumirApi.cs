using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using ExamenPracticoXamarin.Models;
using Newtonsoft.Json;

namespace ExamenPracticoXamarin.Process
{
    public class ConsumirApi
    {
        private string url = "https://randomuser.me/api/?results=30";
        private WebClient cliente = new WebClient();

        private JsonDataModel data = new JsonDataModel();

        public ConsumirApi()
        {
            var json = cliente.DownloadString(url);
            data = JsonConvert.DeserializeObject<JsonDataModel>(json);
        }

        public JsonDataModel Data()
        {
            return data;
        }
        

    }
}
