namespace POC.Dapper.ToDoApi.Domain.Entities
{
  public class Todo : BaseEntity
  {
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
  }
}