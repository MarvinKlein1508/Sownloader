using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sownloader.Core.Utilities;
public static class UserAgentGenerator
{
    private static readonly List<string> _operatingSystems =
    [
        "Windows NT 10.0; Win64; x64",
        "Windows NT 6.1; Win64; x64", // Windows 7
        "Macintosh; Intel Mac OS X 10_15_7",
        "Macintosh; Intel Mac OS X 11_6",
        "X11; Linux x86_64",
        "X11; Ubuntu; Linux x86_64",
        "iPhone; CPU iPhone OS 16_0 like Mac OS X",
        "Android 12; Mobile"
    ];

    private static readonly List<string> _browsers =
    [
        "Mozilla/5.0",
        "AppleWebKit/537.36",
        "Gecko/20100101",
        "Chrome/112.0.5615.138",
        "Safari/537.36",
        "Firefox/115.0",
        "Edge/112.0.1722.64"
    ];

    private static readonly List<string> _platforms =
    [
        "Mozilla/5.0 ({0}) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/{1} Safari/537.36", // Chrome
        "Mozilla/5.0 ({0}) Gecko/20100101 Firefox/{1}",                                      // Firefox
        "Mozilla/5.0 ({0}) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/{1} Safari/605.1.15", // Safari
        "Mozilla/5.0 ({0}) AppleWebKit/537.36 (KHTML, like Gecko) Edge/{1}",                  // Edge
    ];

    private static readonly Random _random = new();

    public static string GenerateRandomUserAgent()
    {
        var os = _operatingSystems[_random.Next(_operatingSystems.Count)];
        var browserVersion = $"{_random.Next(80, 120)}.0.{_random.Next(1000, 9999)}.{_random.Next(10, 99)}";
        var platformTemplate = _platforms[_random.Next(_platforms.Count)];

        return string.Format(platformTemplate, os, browserVersion);
    }
}
