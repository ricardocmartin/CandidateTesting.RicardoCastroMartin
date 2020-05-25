using AutoMapper;
using CandidateTesting.RicardoCastroMartin.Domain.Interfaces;
using System;
using System.Text;

namespace CandidateTesting.RicardoCastroMartin.Domain
{
    public class AgoraLog
    {
        private string _separator = "\t";
        private static ILog _log;
        public AgoraLog(ILog log)
        {
            _log = log;
        }

        public static string GetHeader() {
            StringBuilder sb = new StringBuilder();
            sb.Append("#Version: 1.0\n");
            sb.Append($"#Date: {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")}\n");
            sb.Append("#Fields: provider http-method status-code uri-path time-taken response-size cache-status\n");

            return sb.ToString();
        }

        public override string ToString()
        {
            return $"{_log.Provider}{_separator}{_log.HttpMethod}{_separator}{_log.StatusCode}{_separator}{_log.UriPath}{_separator}{_log.TimeTaken}{_separator}{_log.ResponseSize}{_separator}{_log.CacheStatus}\n";
        }
    }


}
