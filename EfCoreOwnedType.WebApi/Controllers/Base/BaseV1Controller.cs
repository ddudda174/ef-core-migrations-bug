namespace EfCoreOwnedType.WebApi.Controllers.Base
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    public abstract class BaseV1Controller : ControllerBase
    {
    }
}
