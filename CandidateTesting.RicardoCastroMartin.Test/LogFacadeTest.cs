using CandidateTesting.RicardoCastroMartin.Application;
using CandidateTesting.RicardoCastroMartin.Domain;
using CandidateTesting.RicardoCastroMartin.Service;
using Xunit;

namespace CandidateTesting.RicardoCastroMartin.Test
{
    public class LogFacadeTest
    {
        [Fact]
        public void CheckValues()
        {
            //Arrange
            MockLogClient logClient = new MockLogClient();
            MockLogFile logFile = new MockLogFile();
            LogService logService = new LogService(logClient);
            var logFacade = new LogFacade(logService, logFile);

            //Act
            logFacade.ConvertLog();

            //Assert
            Assert.Contains("robots.txt", logFile.content);
            Assert.Contains("myImages", logFile.content);
            Assert.Contains("not-found", logFile.content);
        }
    }
}
