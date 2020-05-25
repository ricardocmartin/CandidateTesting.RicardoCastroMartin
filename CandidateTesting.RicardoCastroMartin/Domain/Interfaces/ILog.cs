namespace CandidateTesting.RicardoCastroMartin.Domain.Interfaces
{
    public interface ILog
    {
        string CacheStatus { get; set; }
        string HttpMethod { get; set; }
        string Provider { get; set; }
        string ResponseSize { get; set; }
        string StatusCode { get; set; }
        string TimeTaken { get; set; }
        string UriPath { get; set; }

        string ToString();
    }
}