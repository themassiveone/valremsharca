using U.Types.Components;
using U.Types.Identities;
using System.Net;
using Newtonsoft.Json;

namespace U.Providers.HttpWebClient;
public class HttpWebClient : Types.Components.WebClient
{
    private HttpClient httpClient;
    private IReporter reporter;
    public HttpWebClient(HttpClient httpClient, IReporter reporter)
    {
        this.httpClient = httpClient;
        this.reporter = reporter;
    }
    public async Task<T> Get<T>(Service service)
    {
        throw new NotImplementedException("Get what?");
        HttpResponseMessage message = await httpClient.GetAsync($"http://{service.serviceType}/{service.shard.id}");
        if (message.IsSuccessStatusCode)
            reporter.Report(new HttpErrorMessage(service, message));
        return JsonConvert.DeserializeObject<T>(await message.Content.ReadAsStringAsync());
    }


    public class HttpErrorMessage : IReportExeption
    {
        public string message { get; set; }
        public Service service { get; set; }

        public HttpErrorMessage(Service service, HttpResponseMessage httpResponseMessage)
        {
            this.service = service;
            this.message = httpResponseMessage.StatusCode.ToString();
        }
    }
}
