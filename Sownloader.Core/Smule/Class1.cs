using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sownloader.Core.Smule;


public class Performance
{
    public string? rec_id { get; set; }
    public string? poi { get; set; }
    public string key { get; set; }
    public string performance_key { get; set; }
    public string? join_link { get; set; }
    public string type { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;
    [JsonPropertyName("artist")]
    public string Artist { get; set; } = string.Empty;
    public string? message { get; set; }
    public DateTime created_at { get; set; }
    public DateTime? expire_at { get; set; }
    public bool seed { get; set; }
    public bool closed { get; set; }
    public string ensemble_type { get; set; }
    public int child_count { get; set; }
    public string app_uid { get; set; }
    public string arr_type { get; set; }
    public string arr_key { get; set; }
    public string? song_id { get; set; }
    public int? song_length { get; set; }
    public string perf_status { get; set; }
    public string? artist_twitter { get; set; }
    public string? media_url { get; set; }
    public string? video_media_url { get; set; }
    public string? video_media_mp4_url { get; set; }
    public string? visualizer_media_url { get; set; }
    public string cover_url { get; set; }
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

public class Stats
{
    public int total_performers { get; set; }
    public string truncated_other_performers { get; set; }
    public int total_listens { get; set; }
    public string truncated_listens { get; set; }
    public int total_loves { get; set; }
    public string truncated_loves { get; set; }
    public int total_comments { get; set; }
    public string truncated_comments { get; set; }
    public int total_commenters { get; set; }
    public int total_gifts { get; set; }
    public string truncated_gifts { get; set; }
}

public class Owner
{
    public int account_id { get; set; }
    public string handle { get; set; }
    public string pic_url { get; set; }
    public float price { get; set; }
    public float discount { get; set; }
    public string url { get; set; }
    public bool is_vip { get; set; }
    public bool is_verified { get; set; }
    public string verified_type { get; set; }
}

