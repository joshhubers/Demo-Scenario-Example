using System.Threading.Tasks;

using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;

using DinoAssetTracker.Models;

namespace DinoAssetTracker.Controllers
{
  public class DinosaurController : JsonApiController<Dinosaur>
  {
    public DinosaurController(
      IJsonApiContext jsonApiContext,
      IResourceService<Dinosaur> resourceService,
      ILoggerFactory loggerFactory)
    : base(jsonApiContext, resourceService, loggerFactory) { }
  }
}