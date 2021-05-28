using CandidateTesting.DanielVPonceDeLeon.iTaaS.Helpers;
using System;

namespace CandidateTesting.DanielVPonceDeLeon.AgoraLogger
{
    internal class Program
    {
				static void Main(string[] args)
				{
						if (args.Length == 2)
						{
								var sourceURI = args[0];
								var targetPath = args[1];

								var mINHACDNParser = new MINHACDNParser();
								var mINHACDNLogs = mINHACDNParser.GetLogs(sourceURI);

								var agoraTranspiler = new AgoraTranspiler();
								agoraTranspiler.TranspileMINHACDN<Program>(mINHACDNLogs, targetPath);

								Console.WriteLine("Log finished transpiling");

						}
						else
								Console.WriteLine("Incorrect number of parameters!");
				}
		}
}
