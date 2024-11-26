using Sownloader.Core.Models;
using Sownloader.Core.Smule;

namespace Sownloader.Core.Mapping;
public static class SmulePerformanceMapping
{
    public static Performance MapToPerformance(this SmulePerformance item)
    {

        return new Performance
        {
            Title = item.Title,
            AudioUrl = item.MediaUrl,
            VideoUrl = item.VideoMediaMp4Url,
            CoverUrl = item.CoverUrl,
            App = item.AppName,
            Artist = item.Artist,
            CreatedAt = item.CreatedAt,
        };
    }
}
