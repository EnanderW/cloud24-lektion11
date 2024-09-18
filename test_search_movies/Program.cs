namespace test_search_movies;

class Program
{
    static void Main(string[] args)
    {
        HttpClient client = new HttpClient { BaseAddress = new Uri("http://10.110.47.63:8080/") };

        var webRequest = new HttpRequestMessage(HttpMethod.Get, "api/movies?search=test");

        var response = client.Send(webRequest);
        Console.WriteLine("Sent");
        Console.WriteLine(response);

        // Läs in kropp i form av JSON och omvandla till objekt
        using var reader = new StreamReader(response.Content.ReadAsStream());
        var json = reader.ReadToEnd();
        Console.WriteLine(json);
    }
}
