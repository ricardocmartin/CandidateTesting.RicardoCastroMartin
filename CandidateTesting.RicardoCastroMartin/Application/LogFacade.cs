using CandidateTesting.RicardoCastroMartin.Domain;
using CandidateTesting.RicardoCastroMartin.Infra;
using CandidateTesting.RicardoCastroMartin.Infra.Interfaces;
using CandidateTesting.RicardoCastroMartin.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateTesting.RicardoCastroMartin.Application
{
    public class LogFacade
    {
        private readonly ILogService _logService;
        private readonly ILogFile _logFile;

        public LogFacade(ILogService logService, ILogFile logFile)
        {
            _logService = logService;
            _logFile = logFile;
        }

        public void ConvertLog() {
            var logContent = _logService.GetString().Split("\n");
            StringBuilder logResult = new StringBuilder();
            
            foreach (string line in logContent)
            {
                if(!string.IsNullOrEmpty(line))
                    logResult.Append(new AgoraLog(new MinhaCDNLog(line).GetLog()).ToString());
            }
            
            _logFile.Save(AgoraLog.GetHeader() + logResult.ToString());
        }
    }

}
