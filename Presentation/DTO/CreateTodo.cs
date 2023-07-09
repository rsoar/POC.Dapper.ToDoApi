namespace POC.Dapper.ToDoApi.Presentation.DTO
{
  public record CreateTodo
  {
    public string Title { get; init;}
    public string Description { get; init;}

    public CreateTodo(string title, string description) {
        Title = title;
        Description = description;
    }

    public void Deconstruct(out string title, out string description)
    {
        title = Title;
        description = Description;
    }
  };
}