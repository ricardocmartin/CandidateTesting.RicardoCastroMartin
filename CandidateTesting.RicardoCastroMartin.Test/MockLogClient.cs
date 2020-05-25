using CandidateTesting.RicardoCastroMartin.Infra.Interfaces;
using System.Text;

namespace CandidateTesting.RicardoCastroMartin.Test
{
    public class MockLogClient : ILogClient
    {
        public string GetString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("312|200|HIT|\"GET /robots.txt HTTP/1.1\"|100.2\n");
            sb.Append("101|200|MISS|\"POST /myImages HTTP/1.1\"|319.4\n");
            sb.Append("199|404|MISS|\"GET /not-found HTTP/1.1\"|142.9\n");
            sb.Append("312|200|INVALIDATE|\"GET /robots.txt HTTP/1.1\"|245.1\n");

            return sb.ToString();
        }
    }
}
