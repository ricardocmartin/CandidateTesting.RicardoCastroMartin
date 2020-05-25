using CandidateTesting.RicardoCastroMartin.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CandidateTesting.RicardoCastroMartin.Infra
{
    public class LogClient : ILogClient
    {
        private string _url = "";
        private HttpWebRequest _client;

        public LogClient(HttpWebRequest client)
        {
            _client = client;
        }

        public string GetString()
        {
            string responseString = "";
            _client.Method = "GET";
            using (HttpWebResponse response = (HttpWebResponse)_client.GetResponse()){
                using (Stream responseStream = response.GetResponseStream()){
                    using (StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8)){
                        responseString = streamReader.ReadToEnd();
                    }
                }
            }

            return responseString;

        }




    }
}
