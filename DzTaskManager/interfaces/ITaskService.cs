namespace DzTaskManager
{
    public interface ITaskService
    {
        Task<List<UserTask>> GetAllTasksAsync();
        Task CreateTaskAsync(string description, bool isCompleted);
        Task UpdateTaskAsync(UserTask task);
        Task DeleteTaskAsync(Guid id);
    }
}
