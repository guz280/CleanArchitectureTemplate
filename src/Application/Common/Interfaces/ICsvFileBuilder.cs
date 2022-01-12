using CleanArchitectureTemplate.Application.TodoLists.Queries.ExportTodos;

namespace CleanArchitectureTemplate.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
