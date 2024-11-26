using Microsoft.AspNetCore.Mvc;
using Sownloader.Core.Services;

namespace Sownloader.Api.Controllers;

[ApiController]
public class PerformanceController :ControllerBase
{
    private readonly PerformanceService _performanceService;

    public PerformanceController(PerformanceService performanceService)
    {
        _performanceService = performanceService;
    }

    [HttpGet(ApiEndpoints.Performances.Get)]
    public async Task<IActionResult> GetPerformanceAsync([FromRoute] string performance_key,
        CancellationToken token)
    {
        var result = await _performanceService.GetFromSmuleAsync(performance_key, token);
        return Ok(result);
    }
}
