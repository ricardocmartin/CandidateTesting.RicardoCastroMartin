using CandidateTesting.RicardoCastroMartin.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CandidateTesting.RicardoCastroMartin.Domain.Model
{
    public class Log : ILog
    {
        public string Provider { get; set; }
        public string HttpMethod { get; set; }
        public string StatusCode { get; set; }
        public string UriPath { get; set; }
        public string TimeTaken { get; set; }
        public string ResponseSize { get; set; }
        public string CacheStatus { get; set; }


        public override string ToString()
        {
            return base.ToString();
        }
    }


}
