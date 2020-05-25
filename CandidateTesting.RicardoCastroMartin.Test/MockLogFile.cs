using CandidateTesting.RicardoCastroMartin.Infra.Interfaces;

namespace CandidateTesting.RicardoCastroMartin.Test
{
    public class MockLogFile : ILogFile
    {
        public string content { get; private set; }
        public void Save(string _content)
        {
            content = _content;

        }
    }
}
