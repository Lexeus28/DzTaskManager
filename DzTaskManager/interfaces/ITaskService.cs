namespace DzTaskManager
{
    public interface ITaskService
    {
        Task<List<UserTask>> GetAllTasksAsync();
        Task<UserTask> GetTaskByIdAsync(Guid id);
        Task CreateTaskAsync(string description, bool isCompleted);
        Task UpdateTaskAsync(UserTask task);
        Task MarkAsCompletedAsync(Guid id);
        Task DeleteTaskAsync(Guid id);
    }
}
