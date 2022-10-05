using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using U.Types.Components;
using U.Types.Identities;

namespace U.Providers.Intersharding;

[ApiController]
[Route("[controller]")]
public class IntershardingController : ControllerBase
{
    private IServiceIdentity serviceIdentity;
    private IStore store;
    public IntershardingController(IServiceIdentity serviceIdentity, IStore store)
    {
        this.serviceIdentity = serviceIdentity;
        this.store = store;
        Result.okFunc = Ok;
        Result.badFunc = BadRequest;
    }


    //debug only 
    [HttpGet]
    public ActionResult<Result> GetAll()
    {
        return Ok(store.identities.ToArray());
    }


    [HttpGet("{id}")]
    public ActionResult<Result> GetObject(Guid id)
    {
        if (!store.identities.ContainsKey(id))
            return RT.IdNotFound.From();
        Identity identity = store.identities[id];
        Type actual = identity.GetType();
        return new ShardedObject(id, actual.AssemblyQualifiedName, JsonConvert.SerializeObject(Convert.ChangeType(identity, actual))).From();
    }

    [HttpPost]
    public ActionResult<Result> AddObject(ShardedObject pleaseAdd)
    {
        Console.WriteLine(pleaseAdd.fullType);
        Type t = Type.GetType(pleaseAdd.fullType);
        Console.WriteLine(t);
        if (t is null)
            return RT.TypeNotFound.From();
        //does not go here 

        if (store.identities.ContainsKey(pleaseAdd.id))
            return RT.IdAlreadyExisted.From();
        var objectResult = JsonConvert.DeserializeObject(pleaseAdd.payload, t);
        if (objectResult is Identity i)
        {
            store.identities[pleaseAdd.id] = i;
            return RT.Ok.From();
        }
        else
            return RT.CantAddNonIdentities.From();
    }


}
public class ShardedObject
{
    public string fullType { get; set; }
    public Guid id { get; set; }
    public string payload { get; set; }
    public ShardedObject(Guid id, string fullType, string payload)
    {
        this.id = id;
        this.fullType = fullType;
        this.payload = payload;
    }


}



public class Result
{
    public ShardedObject? data { get; set; }
    public RT resultType { get; set; }
    public string humanResult { get; set; }

    public static Func<object, ActionResult> okFunc { get; set; }
    public static Func<object, ActionResult> badFunc { get; set; }

    public Result(RT resultType, ShardedObject data)
    {
        this.data = data;
        this.resultType = resultType;
        this.humanResult = resultType.ToString();
    }
    public Result(RT resultType)
    {
        this.resultType = resultType;
        this.humanResult = resultType.ToString();

    }

    public static ActionResult<Result> From(RT resultType)
    {
        var res = new Result(resultType);
        if (resultType == RT.Ok)
            return okFunc(res);
        return badFunc(res);
    }
    public static ActionResult<Result> From(ShardedObject returnObject)
    {
        return okFunc(new Result(RT.Ok, returnObject));
    }
}
public enum RT
{

    Ok = 0,
    IdNotFound = 1,
    TypeNotFound = 2,
    CantAddNonIdentities = 3,
    IdAlreadyExisted = 4,

}

public static class ResultExtension
{
    public static ActionResult<Result> From(this RT resultType)
    {
        return Result.From(resultType);
    }
    public static ActionResult<Result> From(this ShardedObject shardedObject)
    {
        return Result.From(shardedObject);
    }
}
