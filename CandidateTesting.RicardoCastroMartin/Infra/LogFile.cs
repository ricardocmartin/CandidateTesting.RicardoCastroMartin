using CandidateTesting.RicardoCastroMartin.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CandidateTesting.RicardoCastroMartin.Infra
{
    public class LogFile : ILogFile
    {
        string _path;

        public LogFile(string path)
        {
            _path = path;
        }

        public void Save(string _content)
        {
            File.WriteAllText(_path, _content);
        }
    }
}
