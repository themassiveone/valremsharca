using Microsoft.AspNetCore.Mvc;
using U.Types.Components;

namespace U.Providers.Tick;

[ApiController]
[Route("[controller]")]
public class TickController : ControllerBase
{
    private readonly IStore store;
    public TickController(IStore store, ProxyBase proxyBase)
    {
        this.store = store;
        Console.WriteLine("create  proxybase singleton");
    }


    [HttpGet]
    public ActionResult Tick()
    {
        store.OnTick();
        return Ok();
    }
}