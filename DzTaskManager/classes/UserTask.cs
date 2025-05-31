using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DzTaskManager
{
    public class UserTask
    {
        [Key]
        public Guid Task_id { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; }
    }
}