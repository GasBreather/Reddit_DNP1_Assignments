using Domain.Models;

namespace Domain.DTOs;

public class PostBasicDto
{
    public int ID { get; set; }
    public User OP { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }

    public PostBasicDto(User OP, string Title, string Body)
    {
        this.OP = OP;
        this.Title = Title;
        this.Body = Body;
    }
}