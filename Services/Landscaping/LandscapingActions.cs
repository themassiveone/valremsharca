using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Landscaping.Controllers;

[ApiController]
[Route("[controller]")]
public class LandscapingActionsController : ControllerBase
{
    //Add Spatial Partitioning afterwards
    private LandscapingStore store;
    public LandscapingActionsController(LandscapingStore store)
    {
        this.store = store;
    }
    [HttpPost]
    public ActionResult AddAction(AddLandscapingActionRequest request)
    {
        store.requests.Add(request);
        return Ok();
    }

    [HttpGet]
    public ActionResult<AddLandscapingActionRequest[]> GetActionResult()
    {
        return Ok(store.requests.ToArray());
    }
}

public class AddLandscapingActionRequest
{
    public Vector3 origin { get; set; }
    public Vector3 direction { get; set; }
}

public class Vector3
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }
}
