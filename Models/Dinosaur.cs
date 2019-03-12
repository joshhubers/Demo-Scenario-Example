using JsonApiDotNetCore.Models;

namespace DinoAssetTracker.Models
{
  public class Dinosaur : Identifiable
  {
    [Attr("name")]
    public string Name { get; set; }
  }
}