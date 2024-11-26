using System.Text.Json.Serialization;

namespace Sownloader.Core.Smule;

public class SmulePerformance
{
    [JsonPropertyName("rec_id")]
    public string? RecId { get; set; }
    [JsonPropertyName("poi")]
    public string? Poi { get; set; }
    [JsonPropertyName("key")]
    public required string Key { get; set; }
    [JsonPropertyName("performance_key")]
    public required string PerformanceKey { get; set; }
    [JsonPropertyName("join_link")]
    public string? JoinLink { get; set; }
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;
    [JsonPropertyName("artist")]
    public string Artist { get; set; } = string.Empty;
    [JsonPropertyName("message")]
    public string? Message { get; set; }
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonPropertyName("expire_at")]
    public DateTime? ExpireAt { get; set; }
    public bool seed { get; set; }
    public bool closed { get; set; }
    public string ensemble_type { get; set; }
    public int child_count { get; set; }
    [JsonPropertyName("app_uid")]
    public required string AppName { get; set; }
    public string arr_type { get; set; }
    public string arr_key { get; set; }
    public string? song_id { get; set; }
    public int? song_length { get; set; }
    public string perf_status { get; set; }
    public string? artist_twitter { get; set; }
    [JsonPropertyName("media_url")]
    public string? MediaUrl { get; set; }
    [JsonPropertyName("video_media_url")]
    public string? VideoMediaUrl { get; set; }
    [JsonPropertyName("video_media_mp4_url")]
    public string? VideoMediaMp4Url { get; set; }
    public string? visualizer_media_url { get; set; }
    [JsonPropertyName("cover_url")]
    public string CoverUrl { get; set; } = string.Empty;
    public string web_url { get; set; }
    public string song_info_url { get; set; }
    public Stats stats { get; set; }
    public string performed_by { get; set; }
    public string performed_by_url { get; set; }
    public Owner owner { get; set; }
    public object[] other_performers { get; set; }
    public object duet { get; set; }
    public object other { get; set; }
    public bool featured { get; set; }
    public object rm { get; set; }
    public bool _private { get; set; }
    public string form_type { get; set; }
    public object video_resolution { get; set; }
}

