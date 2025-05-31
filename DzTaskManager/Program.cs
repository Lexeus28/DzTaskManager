using DzTaskManager;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        SQLitePCL.Batteries.Init();

        var services = new ServiceCollection();
        var context = new TaskDBContext();
        context.Database.Migrate();

        services.AddTransient<TaskDBContext>();
        services.AddTransient<ITaskRepository, SQLiteTaskRepository>();
        services.AddTransient<ITaskService, TaskService>();

        var provider = services.BuildServiceProvider();

        ApplicationConfiguration.Initialize();

        var mainForm = new MainForm(provider.GetRequiredService<ITaskService>());
        Application.Run(mainForm);
    }
}