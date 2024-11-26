using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sownloader.Core.Utilities;
public static class UrlParser
{
    private const string SECRET_KEY = "TT18WlV5TXVeLXFXYn1WTF5qSmR9TXYpOHklYlFXWGY+SUZCRGNKPiU0emcyQ2l8dGVsamBkVlpA";
    private static string _registeredSecretCharPool = string.Empty;
    private static readonly string[] _validStartPatterns =
    [
        "https://smule.com/",
        "http://smule.com/",
        "https://www.smule.com/",
        "http://smule.com/",
        "smule.com/",
        "www.smule.com"
    ];
    static UrlParser()
    {
        // Register secret char pool
        _registeredSecretCharPool = RegisterCharPool(SECRET_KEY);
    }

    /// <summary>
    /// Parses a full length Smule URL into a short URL.
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static string ParseSmuleURL(string url)
    {
        // Example: http://www.smule.com/recording/a-great-big-world-ft-christina-aguilera-say-something/125820910_74092872
        // TO: https://smule.com/p/125820910_74092872

        // Define the regex pattern
        string pattern = @"[0-9]+_[0-9]+";

        // Match the pattern in the URL
        Match match = Regex.Match(url, pattern);

        // Check if a match is found
        if (match.Success)
        {
            return "https://smule.com/p/" + match.Value;
        }

        return string.Empty;
    }

    private static string RegisterCharPool(string key)
    {
        Dictionary<char, int> k = [];
        int a = 0, l = 0, d = 0, c = 0, h = key.Length, b;
        string charPool = "";

        for (a = 0; 64 > a; a++)
        {
            k.Add("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/"[a], a);
        }

        for (d = 0; d < h; d++)
        {
            char index = key[d];

            for (a = k.ContainsKey(index) ? k[index] : 0, l = (l << 6) + a, c += 6; 8 <= c;)
            {
                c -= 8;
                b = l >> c & 255;

                if (b != 0 || d < h - 2)
                    charPool += (char)b;
            }
        }

        return charPool;
    }

    public static string ProcessRecording(string? urlEncoded)
    {
        if (urlEncoded is null)
        {
            return $"No encoded URL found. <NULL>";
        }

        if (2 > urlEncoded.Length || 0 != urlEncoded.IndexOf("e:"))
        {
            return urlEncoded;
        }

        string publicCharPool = RegisterCharPool(urlEncoded[2..]);
        Console.WriteLine("PublicCharPool:");
        Console.WriteLine(publicCharPool);
        Dictionary<int, int> a = [];
        int h = 0;
        int d;
        string urlDecoded = "";
        int b;

        for (b = 0; 256 > b; b++)
        {
            a.Add(b, b);
        }

        for (b = 0; 256 > b; b++)
        {
            h = (h + a[b] + _registeredSecretCharPool[b % _registeredSecretCharPool.Length]) % 256;
            d = a[b];
            a[b] = a[h];
            a[h] = d;
        }


        for (int e = b = h = 0; e < publicCharPool.Length; e++)
        {

            b = (b + 1) % 256;
            h = (h + a[b]) % 256;
            d = a[b];
            a[b] = a[h];
            a[h] = d;

            urlDecoded += (char)(publicCharPool[e] ^ a[(a[b] + a[h]) % 256]);
        }

        if (0 != urlDecoded.IndexOf("http"))
        {
            return $"Failed to decode URL {urlEncoded}; got {urlDecoded}";
        }

        return urlDecoded;
    }
}
