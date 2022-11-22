using Domain.Models;

namespace Domain.DTOs;
public class PostCreationDto
{
    public int OwnerId { get; }
    public string OP { get; }
    public string Title { get; }
    public string Body { get; }

    public PostCreationDto(int id, string OP, string title, string body)
    {
        OwnerId = id;
        this.OP = OP;
        Title = title;
        Body = body;
    }
}