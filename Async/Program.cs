public class Async
{

    public string DownloadAndProcess(string url)
    {
        var client = new HttpClient();
        var response = client.GetAsync(url).Result;
        var content = response.Content.ReadAsStringAsync().Result;
        return content.ToUpper();
    }
}
