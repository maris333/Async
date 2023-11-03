public class Async
{

    public async Task<string> DownloadAndProcess(string url)
    {
        var client = new HttpClient();
        var response = await client.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();
        return content.ToUpper();
    }
}
