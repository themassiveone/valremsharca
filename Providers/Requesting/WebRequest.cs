using System.Net;

namespace U.Providers.Requesting;

/*
public static class WebRequest
{
    private static class

}

static async Task Main()
{
    // Call asynchronous network methods in a try/catch block to handle exceptions.
    try
    {
        HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        // Above three lines can be replaced with new helper method below
        // string responseBody = await client.GetStringAsync(uri);

        Console.WriteLine(responseBody);
    }
    catch (HttpRequestException e)
    {
        Console.WriteLine("\nException Caught!");
        Console.WriteLine("Message :{0} ", e.Message);
    }
}
*/