using Dapper;
using POC.Dapper.ToDoApi.Domain.Entities;
using POC.Dapper.ToDoApi.Presentation.DTO;
using System.Data.SqlClient;

namespace POC.Dapper.ToDoApi.Domain
{
    public class TodoService : BaseService
    {
        private readonly SqlConnection _db;
        public TodoService(IConfiguration configuration, SqlConnection connection) : base(configuration, connection) 
        { 
            _db = connection;
        }

        public List<Todo> ToList()
        {
            List<Todo> todos = _db
                .Query<Todo>("SELECT * FROM Todos")
                .ToList();

            return todos;
        }

        public void Create(CreateTodo dto)
        {
            _db.Execute("INSERT INTO Todos (Title, Description) VALUES (@Title, @Description)", dto);
        }
    }
}
