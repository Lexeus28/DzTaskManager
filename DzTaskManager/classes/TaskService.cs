namespace DzTaskManager
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repository;

        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<UserTask>> GetAllTasksAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<UserTask> GetTaskByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task CreateTaskAsync(string description, bool isCompleted)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Описание не может быть пустым");

            var task = new UserTask
            {
                Task_id = Guid.NewGuid(),
                Description = description,
                IsCompleted = isCompleted
            };

            await _repository.AddAsync(task);
        }

        public async Task UpdateTaskAsync(UserTask task)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            await _repository.UpdateAsync(task);
        }

        public async Task MarkAsCompletedAsync(Guid id)
        {
            var task = await _repository.GetByIdAsync(id);
            if (task != null && !task.IsCompleted)
            {
                task.IsCompleted = true;
                await _repository.UpdateAsync(task);
            }
        }

        public async Task DeleteTaskAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
