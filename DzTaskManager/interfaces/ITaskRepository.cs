namespace DzTaskManager
{
    public interface ITaskRepository
    {
        Task<List<UserTask>> GetAllAsync();
        Task AddAsync(UserTask task);
        Task UpdateAsync(UserTask task);
        Task DeleteAsync(Guid id);
    }
}
