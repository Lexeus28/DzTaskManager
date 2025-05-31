using Microsoft.EntityFrameworkCore;
namespace DzTaskManager
{
    public class SQLiteTaskRepository : ITaskRepository
    {
        private readonly TaskDBContext _context;

        public SQLiteTaskRepository(TaskDBContext context)
        {
            _context = new TaskDBContext();
        }

        public async Task<List<UserTask>> GetAllAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<UserTask> GetByIdAsync(Guid id)
        {
            return await _context.Tasks
                .FirstOrDefaultAsync(t => t.Task_id == id);
        }

        public async Task AddAsync(UserTask task)
        {
            if (task.Task_id == default)
            {
                task.Task_id = Guid.NewGuid();
            }

            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(UserTask task)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var task = await GetByIdAsync(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }
    }
}
