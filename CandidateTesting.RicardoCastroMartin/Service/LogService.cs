using CandidateTesting.RicardoCastroMartin.Infra;
using CandidateTesting.RicardoCastroMartin.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateTesting.RicardoCastroMartin.Service
{
    public class LogService : ILogService
    {
        private readonly ILogClient client;

        public LogService(ILogClient client)
        {
            this.client = client;
        }

        public string GetString()
        {
            return client.GetString();
        }
    }
}
