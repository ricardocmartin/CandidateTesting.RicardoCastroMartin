using CandidateTesting.RicardoCastroMartin.Domain.Interfaces;
using CandidateTesting.RicardoCastroMartin.Domain.Model;

namespace CandidateTesting.RicardoCastroMartin.Domain
{
    public class MinhaCDNLog
    {

        private string _separator = "\t";
        private ILog _log;

        public MinhaCDNLog(string LogString)
        {
            this.FromString(LogString);
        }

        public ILog GetLog() {
            return _log;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public MinhaCDNLog FromString(string LogString) {
            var row = LogString.Split('|');

            if (_log is null)
                _log = new Log();

            _log.Provider = "\"Minha CDN\"";
            _log.HttpMethod = row[3].Split(" ")[0].Substring(1);
            _log.StatusCode = row[1];
            _log.UriPath = row[3].Split(" ")[1];
            _log.TimeTaken = row[4].Split('.')[0]; //TODO: Corret format 100.2 to 100
            _log.ResponseSize= row[0];
            _log.CacheStatus = row[2];

            return this;
        }
    }


}
