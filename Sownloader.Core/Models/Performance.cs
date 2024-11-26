using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sownloader.Core.Models;
public class Performance
{
    public required string Title { get; set; }
    public required string? AudioUrl { get; set; }
    public required string? VideoUrl { get; set; }
    public required string? CoverUrl { get; set; }
    public required string App { get; set; }


}
