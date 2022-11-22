using System.Text.Json.Serialization;

namespace Domain.Models;

public class User
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public int Id { get; set; }
    [JsonIgnore]
    public ICollection<Post> Posts { get; set; }
}