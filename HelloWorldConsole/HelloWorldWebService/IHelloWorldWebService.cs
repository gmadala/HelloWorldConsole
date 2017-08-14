using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole.HelloWorldWebService
{
    interface IHelloWorldWebService
    {
        string DisplayHelloWorld();
    }
    public interface IAppSettings
    {
        string Get(string name);
    }
    public interface IDataService
    {
        /// <summary>
        ///     Gets today's data
        /// </summary>
        /// <returns>A TodaysData model containing today's data</returns>
        //TodaysData GetTodaysData();
    }
    public interface IUri
    {
        Uri GetUri(string uriString);
    }
}
