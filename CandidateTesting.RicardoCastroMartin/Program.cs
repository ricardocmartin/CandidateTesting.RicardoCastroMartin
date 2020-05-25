using CandidateTesting.RicardoCastroMartin.Application;
using CandidateTesting.RicardoCastroMartin.Infra;
using CandidateTesting.RicardoCastroMartin.Service;
using System;
using System.IO;
using System.Net;
using System.Net.Http.Headers;

namespace CandidateTesting.RicardoCastroMartin
{
    public class Program
    {
        static void Main(string[] args)
        {
            string comand = args[0];

            switch (comand) 
            { 
                case "convert":
                    string url = args[1];
                    string path = args[2];

                    var logFacade = new LogFacade(
                          new LogService(new LogClient(
                                                WebRequest.CreateHttp(url)
                              ))
                        , new LogFile(path)
                    );

                    logFacade.ConvertLog();
                    break;
                default:
                    Console.WriteLine("Comand not found");
                    break;
            }
        }
    }
}
