using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sownloader.Core.Smule;

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

