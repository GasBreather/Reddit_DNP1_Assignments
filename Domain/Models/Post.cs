using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Post
{
    [Key]
    public int ID { get; set; }
    public User OP { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }

    public Post(int id, User OP, string Title, string Body)
    {
        this.ID = id;
        this.OP = OP;
        this.Title = Title;
        this.Body = Body;
    }
    private Post(){}

}