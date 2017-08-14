using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldConsole.DataFile;
using RestSharp;

namespace HelloWorldConsole.HelloWorldWebService
{
    public class AppSettingsKeys
    {
        public const string HelloWorldApiUrlKey = "HelloWorldAPIURL";
    }
    class HelloWorldWebService
    {
        private readonly IRestClient restClient;
        
        private readonly IRestRequest restRequest;

        private readonly IAppSettings appSettings;

        private readonly IUri uriService;
        public HelloWorldWebService(
            IRestClient restClient,
            IRestRequest restRequest,
            IAppSettings appSettings,
            IUri uriService
        )
        {
            this.restClient = restClient;
            this.restRequest = restRequest;
            this.appSettings = appSettings;
            this.uriService = uriService;
        }
        public HelloWorldData DisplayHelloWorld()
        {
            HelloWorldData displayHelloWorld = null;

            this.restClient.BaseUrl = this.uriService.GetUri(this.appSettings.Get(AppSettingsKeys.HelloWorldApiUrlKey));
            
            this.restRequest.Resource = "displayHelloWorld";
            this.restRequest.Method = Method.GET;
            
            var helloWorldResponse = this.restClient.Execute<HelloWorldData>(this.restRequest);
            
            if (helloWorldResponse != null)
            {
                if (helloWorldResponse.Data != null)
                {
                    displayHelloWorld = helloWorldResponse.Data;
                }  
            }
            else
            {
                //Displaying the error message
                const string errorMessage =
                    "No response from the Hello World Web Api";
            }

            return displayHelloWorld;
        }
    }
    
}
