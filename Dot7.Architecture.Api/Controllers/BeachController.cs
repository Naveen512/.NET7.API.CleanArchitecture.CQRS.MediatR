using Dot7.Architecture.Application.Beach.CreateBeach;
using Dot7.Architecture.Application.Beach.GetAllBeaches;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Dot7.Architecture.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BeachController : ControllerBase
{
    private readonly IMediator _mediator;
    public BeachController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        var response = await _mediator.Send(new GetAllBeachesRequest());
        return Ok(response);
    }
    [HttpPost]
    public async Task<IActionResult> PostAsync(CreateBeachRequest payload)
    {
        var newlyCreateItemId = await _mediator.Send(payload);
        return Ok(newlyCreateItemId);
    }
}