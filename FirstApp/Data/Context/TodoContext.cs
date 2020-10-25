using Data.Models;
using System.Data.Entity;

namespace Data.Context
{
    public class TodoContext: DbContext
    {

        public TodoContext()
           : base("name=MySqlConnection")
        {
        }
        public DbSet<ToDo> Todos { get; set; }
        

    }
}