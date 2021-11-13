using System.Net;
using TestProject.Utilities.UserInformations;

namespace TestProject.API.Utilities
{
    public class GetUserAgent
    {
        public string GetCreatedIP()
        {

            UserAgent ua = new UserAgent(HttpContext.Current.Request.Headers["User-Agent"]);
            IPAddress ip = HttpContext.Current.Connection.RemoteIpAddress;
            //IPHostEntry GetIPHost = Dns.GetHostEntry(ip);
            //List<string> compName = GetIPHost.HostName.ToString().Split('.').ToList();
            return ip.ToString() + "," + ua.Browser.Name + "," + ua.OS.Name;
            //"," + compName.First() + "," + ua.Browser.Name + "," + ua.OS.Name;
        }
    }
}
