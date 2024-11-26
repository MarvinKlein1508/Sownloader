using Sownloader.Core.Smule;
using Sownloader.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Sownloader.Core.Services;
public class PerformanceService
{
    private readonly HttpClient _client;

    public PerformanceService(HttpClient client)
    {
        _client = client;
    }

    public async Task<Performance?> GetFromSmuleAsync(string performance_key, CancellationToken token = default)
    {
        string api_url = $"/p/{performance_key}/json";

        string userAgent = UserAgentGenerator.GenerateRandomUserAgent();
        string ip = IPAdressGenerator.GeneratePublicIPv4Address();

        _client.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
        _client.DefaultRequestHeaders.Referrer = new Uri("http://www.google.com");
        _client.DefaultRequestHeaders.Add("X-Forwarded-For", ip);


        var result = await _client.GetFromJsonAsync<Performance>(api_url, token);

        return result;
    }
}
